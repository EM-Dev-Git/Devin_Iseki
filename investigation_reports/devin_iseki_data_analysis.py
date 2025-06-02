#!/usr/bin/env python3
"""
Devin_Iseki IbUkeharai Data Analysis Script
データベース内容の詳細分析とエラー原因の特定
"""

import pandas as pd
import numpy as np
from pathlib import Path

def analyze_ukeharai_data():
    """UkeharaiDB_Matsuyama.xlsxファイルの詳細分析"""
    
    print("=== Devin_Iseki IbUkeharai Data Analysis ===")
    print("Repository: EM-Dev-Git/Devin_Iseki")
    print("Branch: main-matsuoka-20250602-002")
    print("Target: UkeharaiDB_Matsuyama.xlsx")
    print()
    
    excel_file = Path("/home/ubuntu/attachments/2d3164a1-1a1b-4b10-b157-e4338f160502/UkeharaiDB_Matsuyama.xlsx")
    
    if not excel_file.exists():
        print(f"ERROR: Excel file not found at {excel_file}")
        return
    
    try:
        print("=== T_UKEHARAIJISSEKI Analysis ===")
        df_jisseki = pd.read_excel(excel_file, sheet_name='T_UKEHARAIJISSEKI')
        
        print(f"Total rows: {len(df_jisseki)}")
        print(f"Columns: {list(df_jisseki.columns)}")
        print()
        
        print("Data types:")
        print(df_jisseki.dtypes)
        print()
        
        print("Sample data (first 5 rows):")
        print(df_jisseki.head())
        print()
        
        numeric_columns = ['ZAIKOSU', 'UKESU', 'HARASU']
        for col in numeric_columns:
            if col in df_jisseki.columns:
                print(f"{col} statistics:")
                print(f"  Min: {df_jisseki[col].min()}")
                print(f"  Max: {df_jisseki[col].max()}")
                print(f"  Mean: {df_jisseki[col].mean():.2f}")
                print(f"  Null count: {df_jisseki[col].isnull().sum()}")
                print()
                
                large_values = df_jisseki[df_jisseki[col] > 999999]
                if len(large_values) > 0:
                    print(f"  Records with {col} > 999,999: {len(large_values)}")
                    print(f"  Max value causing overflow: {df_jisseki[col].max()}")
                    print()
        
        if 'UKEHARA_YYYYMM' in df_jisseki.columns:
            unique_months = df_jisseki['UKEHARA_YYYYMM'].unique()
            print(f"UKEHARA_YYYYMM unique values: {unique_months}")
            print()
        
        print("=== T_UKEHARAIMEISAI Analysis ===")
        df_meisai = pd.read_excel(excel_file, sheet_name='T_UKEHARAIMEISAI')
        
        print(f"Total rows: {len(df_meisai)}")
        print(f"Columns: {list(df_meisai.columns)}")
        print()
        
        if 'KOSU' in df_meisai.columns:
            print("KOSU statistics:")
            print(f"  Min: {df_meisai['KOSU'].min()}")
            print(f"  Max: {df_meisai['KOSU'].max()}")
            print(f"  Mean: {df_meisai['KOSU'].mean():.2f}")
            print()
            
            large_kosu = df_meisai[df_meisai['KOSU'] > 999999]
            if len(large_kosu) > 0:
                print(f"  Records with KOSU > 999,999: {len(large_kosu)}")
                print(f"  Max KOSU value: {df_meisai['KOSU'].max()}")
                print()
        
        if 'UKEHARA_YYYYMMDD' in df_meisai.columns:
            sample_dates = df_meisai['UKEHARA_YYYYMMDD'].head().tolist()
            print(f"UKEHARA_YYYYMMDD sample values: {sample_dates}")
            print()
        
        print("=== SQL Server Data Type Limitation Analysis ===")
        print("NVARCHAR(7) limitation: 7 characters maximum")
        print("numeric(7,0) limitation: 7 digits maximum (9,999,999)")
        print()
        
        overflow_analysis = []
        for col in numeric_columns:
            if col in df_jisseki.columns:
                max_val = df_jisseki[col].max()
                if max_val >= 9999999:
                    overflow_analysis.append({
                        'column': col,
                        'max_value': max_val,
                        'overflow_risk': 'HIGH - Exceeds numeric(7,0) limit'
                    })
                elif max_val > 999999:
                    overflow_analysis.append({
                        'column': col,
                        'max_value': max_val,
                        'overflow_risk': 'MEDIUM - Close to limit'
                    })
        
        if overflow_analysis:
            print("Overflow Risk Analysis:")
            for analysis in overflow_analysis:
                print(f"  {analysis['column']}: {analysis['max_value']} - {analysis['overflow_risk']}")
            print()
        
        print("=== Root Cause Confirmation ===")
        zaikosu_max = df_jisseki['ZAIKOSU'].max() if 'ZAIKOSU' in df_jisseki.columns else 0
        ukesu_max = df_jisseki['UKESU'].max() if 'UKESU' in df_jisseki.columns else 0
        
        if zaikosu_max >= 9999999 or ukesu_max >= 9999999:
            print("✅ CONFIRMED: Data contains values at/exceeding numeric(7,0) limit")
            print(f"   ZAIKOSU max: {zaikosu_max}")
            print(f"   UKESU max: {ukesu_max}")
            print("   This directly causes the arithmetic overflow in Update_Month_Data")
        else:
            print("❌ Data values within limits - investigate other causes")
        
        print()
        print("=== Investigation Summary ===")
        print("Repository: EM-Dev-Git/Devin_Iseki")
        print("Error Location: Ukeharai.Update_Month_Data stored procedure")
        print("VB.NET Code: BatchMonthlyDataForm.vb line 264 (DateTime conversion)")
        print("SQL Code: Update_Month_Data.txt lines 130-132 (numeric conversion)")
        print("Data Issue: Values exceeding SQL Server data type limits")
        
    except Exception as e:
        print(f"Error analyzing data: {e}")
        import traceback
        traceback.print_exc()

if __name__ == "__main__":
    analyze_ukeharai_data()
