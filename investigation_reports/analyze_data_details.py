import pandas as pd

try:
    df = pd.read_excel('/home/ubuntu/attachments/2d3164a1-1a1b-4b10-b157-e4338f160502/UkeharaiDB_Matsuyama.xlsx', sheet_name='T_UKEHARAIJISSEKI')
    print("=== T_UKEHARAIJISSEKI Analysis ===")
    print(f"Total rows: {len(df)}")
    print(f"Columns: {list(df.columns)}")
    print("\nData types:")
    print(df.dtypes)
    
    print("\nSample data (first 5 rows):")
    print(df.head())
    
    numeric_cols = ['ZAIKOSU', 'UKESU', 'HARASU']
    for col in numeric_cols:
        if col in df.columns:
            print(f"\n{col} statistics:")
            print(f"  Min: {df[col].min()}")
            print(f"  Max: {df[col].max()}")
            print(f"  Mean: {df[col].mean():.2f}")
            print(f"  Null count: {df[col].isnull().sum()}")
            
            large_values = df[df[col] > 999999999]
            if len(large_values) > 0:
                print(f"  WARNING: {len(large_values)} rows with very large values (>999,999,999)")
                print(f"  Largest values: {df[col].nlargest(5).tolist()}")
    
    print(f"\nUKEHARA_YYYYMM unique values: {df['UKEHARA_YYYYMM'].unique()}")
    
except Exception as e:
    print(f"Error analyzing T_UKEHARAIJISSEKI: {e}")

try:
    df2 = pd.read_excel('/home/ubuntu/attachments/2d3164a1-1a1b-4b10-b157-e4338f160502/UkeharaiDB_Matsuyama.xlsx', sheet_name='T_UKEHARAIMEISAI')
    print("\n=== T_UKEHARAIMEISAI Analysis ===")
    print(f"Total rows: {len(df2)}")
    print(f"Columns: {list(df2.columns)}")
    
    if 'KOSU' in df2.columns:
        print(f"\nKOSU statistics:")
        print(f"  Min: {df2['KOSU'].min()}")
        print(f"  Max: {df2['KOSU'].max()}")
        print(f"  Mean: {df2['KOSU'].mean():.2f}")
        
        large_kosu = df2[df2['KOSU'] > 999999999]
        if len(large_kosu) > 0:
            print(f"  WARNING: {len(large_kosu)} rows with very large KOSU values")
            print(f"  Largest KOSU values: {df2['KOSU'].nlargest(5).tolist()}")
    
    print(f"\nUKEHARA_YYYYMMDD sample values: {df2['UKEHARA_YYYYMMDD'].head().tolist()}")
    
except Exception as e:
    print(f"Error analyzing T_UKEHARAIMEISAI: {e}")
