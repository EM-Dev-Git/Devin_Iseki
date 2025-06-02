import pandas as pd
from datetime import datetime

print("=== DETAILED ERROR ANALYSIS ===")
print()

print("1. ERROR PATTERN FROM LOG:")
print("   - Error: 'expression をデータ型 nvarchar に変換中に、算術オーバーフロー エラーが発生しました'")
print("   - Translation: 'Arithmetic overflow error occurred while converting expression to nvarchar data type'")
print("   - Stored Procedure: Ukeharai.Update_Month_Data")
print("   - Execution Date: 2025/05/01 (from log ExecYMD[2025/05/01 0:00:00])")
print()

print("2. STORED PROCEDURE PARAMETERS (from CreateUpdateStoredParam):")
print("   - @S_ToriCd: SqlDbType.NVarChar (取引先コード - Trading Partner Code)")
print("   - @D_ExecYYYYMMDD: SqlDbType.Date (実行日 - Execution Date)")
print("   - @ID_User: SqlDbType.NVarChar (ユーザーID - User ID)")
print("   - @D_UpdateTime: SqlDbType.DateTime (更新時刻 - Update Time)")
print("   - @ID_Func: SqlDbType.NVarChar ('BatchMonthlyData')")
print()

df = pd.read_excel('/home/ubuntu/attachments/2d3164a1-1a1b-4b10-b157-e4338f160502/UkeharaiDB_Matsuyama.xlsx', sheet_name='T_UKEHARAIJISSEKI')

print("3. POTENTIAL OVERFLOW DATA ANALYSIS:")
print(f"   - ZAIKOSU (在庫数 - Stock Quantity) max: {df['ZAIKOSU'].max():,}")
print(f"   - UKESU (受数 - Received Quantity) max: {df['UKESU'].max():,}")
print(f"   - HARASU (払数 - Paid Quantity) max: {df['HARASU'].max():,}")
print()

large_zaikosu = df[df['ZAIKOSU'] > 999999]
large_ukesu = df[df['UKESU'] > 999999]

print("4. PROBLEMATIC DATA RECORDS:")
if len(large_zaikosu) > 0:
    print(f"   - {len(large_zaikosu)} records with ZAIKOSU > 999,999")
    print(f"   - Largest ZAIKOSU values: {df['ZAIKOSU'].nlargest(3).tolist()}")

if len(large_ukesu) > 0:
    print(f"   - {len(large_ukesu)} records with UKESU > 999,999")
    print(f"   - Largest UKESU values: {df['UKESU'].nlargest(3).tolist()}")

print()

print("5. DATETIME CONVERSION ANALYSIS:")
print("   - @D_UpdateTime parameter uses: Conversions.ToString(DateAndTime.Now)")
print("   - This converts DateTime to string, then SQL tries to convert back")
print("   - Potential issue: String format may not match SQL Server expectations")
print("   - Current time format likely: Japanese locale datetime string")
print()

print("6. ROOT CAUSE HYPOTHESIS:")
print("   A. Large numeric values (9,999,999) may exceed SQL Server data type limits")
print("   B. DateTime string conversion may be causing nvarchar overflow")
print("   C. The stored procedure may be trying to convert large numbers to nvarchar")
print("   D. Japanese locale datetime formatting may create oversized strings")
print()

print("7. RECOMMENDED INVESTIGATION:")
print("   - Find the actual Update_Month_Data stored procedure definition")
print("   - Check SQL Server column data types and constraints")
print("   - Verify datetime string format compatibility")
print("   - Test with smaller numeric values to isolate the issue")
