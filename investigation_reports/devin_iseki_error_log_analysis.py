#!/usr/bin/env python3
"""
Devin_Iseki IbUkeharai Error Log Analysis
エラーログの詳細分析とパターン特定
"""

import re
from datetime import datetime
from pathlib import Path

def analyze_error_log():
    """IbUkeharai.logファイルの詳細分析"""
    
    print("=== Devin_Iseki IbUkeharai Error Log Analysis ===")
    print("Repository: EM-Dev-Git/Devin_Iseki")
    print("Branch: main-matsuoka-20250602-002")
    print("Target: IbUkeharai.log")
    print()
    
    log_file = Path("/home/ubuntu/attachments/7d3e0b25-9e23-43c4-9fcd-72e8816cc5a5/IbUkeharai.log")
    
    if not log_file.exists():
        print(f"ERROR: Log file not found at {log_file}")
        return
    
    try:
        with open(log_file, 'r', encoding='utf-8') as f:
            log_content = f.read()
        
        print("=== Error Pattern Analysis ===")
        
        error_pattern = r'UPDATE ERRER \[(.*?)\] : ExecYMD\[(.*?)\]'
        errors = re.findall(error_pattern, log_content)
        
        print(f"Total error occurrences: {len(errors)}")
        print()
        
        if errors:
            print("Error details:")
            for i, (error_msg, exec_date) in enumerate(errors[:10]):  # 最初の10件を表示
                print(f"  {i+1}. Error: {error_msg}")
                print(f"     ExecYMD: {exec_date}")
                print()
        
        timestamp_pattern = r'(\d{4}/\d{2}/\d{2} \d{2}:\d{2}:\d{2})'
        timestamps = re.findall(timestamp_pattern, log_content)
        
        if timestamps:
            print("=== Temporal Analysis ===")
            print(f"First error: {timestamps[0]}")
            print(f"Last error: {timestamps[-1]}")
            print(f"Total error timestamps: {len(timestamps)}")
            print()
            
            try:
                first_time = datetime.strptime(timestamps[0], '%Y/%m/%d %H:%M:%S')
                last_time = datetime.strptime(timestamps[-1], '%Y/%m/%d %H:%M:%S')
                duration = last_time - first_time
                print(f"Error duration: {duration}")
                print(f"Error frequency: {len(timestamps)} errors over {duration}")
                print()
            except ValueError as e:
                print(f"Error parsing timestamps: {e}")
        
        arithmetic_overflow_pattern = r'expression をデータ型 nvarchar に変換中に、算術オーバーフロー エラーが発生しました'
        overflow_matches = re.findall(arithmetic_overflow_pattern, log_content)
        
        print("=== Specific Error Analysis ===")
        print(f"Arithmetic overflow errors: {len(overflow_matches)}")
        
        update_month_pattern = r'UPDATE ERRER.*Update_Month_Data'
        update_month_errors = re.findall(update_month_pattern, log_content)
        print(f"Update_Month_Data related errors: {len(update_month_errors)}")
        print()
        
        exec_ymd_pattern = r'ExecYMD\[(\d{4}/\d{2}/\d{2})'
        exec_dates = re.findall(exec_ymd_pattern, log_content)
        unique_exec_dates = list(set(exec_dates))
        
        print("=== Execution Date Analysis ===")
        print(f"Unique execution dates: {unique_exec_dates}")
        
        may_2025_errors = [date for date in exec_dates if date == '2025/05/01']
        print(f"Errors for 2025/05/01: {len(may_2025_errors)}")
        print()
        
        batch_pattern = r'BatchMonthlyData'
        batch_matches = re.findall(batch_pattern, log_content)
        print("=== Batch Processing Analysis ===")
        print(f"BatchMonthlyData references: {len(batch_matches)}")
        print()
        
        print("=== Error Context Analysis ===")
        
        log_lines = log_content.split('\n')
        error_lines = [line for line in log_lines if 'UPDATE ERRER' in line]
        
        if error_lines:
            print("Sample error lines:")
            for i, line in enumerate(error_lines[:5]):  # 最初の5行を表示
                print(f"  {i+1}. {line.strip()}")
            print()
        
        monthly_error_lines = [line for line in log_lines if '月次処理' in line]
        if monthly_error_lines:
            print("Monthly processing related errors:")
            for i, line in enumerate(monthly_error_lines[:3]):
                print(f"  {i+1}. {line.strip()}")
            print()
        
        print("=== Root Cause Correlation ===")
        print("Error Pattern: Arithmetic overflow in nvarchar conversion")
        print("Affected Procedure: Ukeharai.Update_Month_Data")
        print("VB.NET Source: BatchMonthlyDataForm.vb (CreateUpdateStoredParam)")
        print("SQL Source: Update_Month_Data stored procedure (CONVERT operations)")
        print("Data Issue: Values exceeding numeric(7,0) limits (9,999,999)")
        print()
        
        print("=== Recommended Investigation Points ===")
        print("1. Check SQL Server data type definitions in Update_Month_Data")
        print("2. Verify VB.NET DateTime parameter conversion in BatchMonthlyDataForm")
        print("3. Analyze data values in T_UKEHARAIJISSEKI for overflow conditions")
        print("4. Review error handling in batch processing workflow")
        
    except Exception as e:
        print(f"Error analyzing log file: {e}")
        import traceback
        traceback.print_exc()

if __name__ == "__main__":
    analyze_error_log()
