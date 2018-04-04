using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace App
{
    /// <summary>���ݼ����þ�̬������</summary>
    [Serializable]
    public static class DataOften
    {
        #region Sql���ϲ�����

        /// <summary>�ϲ�Sql��䲢���Sql��ѯ��������</summary>
        /// <param name="SqlStr">��Ҫ�ϲ���Sql���</param>
        /// <param name="ValStr">��Ҫ��ӵĲ���ֵ</param>
        /// <param name="Str">��Ҫ���²������Sql���</param>
        /// <param name="ArrStr">��Ҫ���²������Sql��ѯ��������</param>
        /// <param name="JoStr">Sql�ϲ�ʱ���������</param>
        /// <returns></returns>
        public static void SqlAddArr(string SqlStr, string ValStr, string JoStr, ref StringBuilder Str, ref List<string> ArrStr)
        {
            if (Str.Length > 0)
            {
                Str.Append(JoStr);
            }
            Str.Append(SqlStr);
            ArrStr.Add(ValStr);
        }

        /// <summary>�ϲ�Sql��䲢���Sql��ѯ��������</summary>
        /// <param name="SqlStr">��Ҫ�ϲ���Sql���</param>
        /// <param name="ValStr">��Ҫ��ӵĲ���ֵ</param>
        /// <param name="Str">��Ҫ���²������Sql���</param>
        /// <param name="ArrStr">��Ҫ���²������Sql��ѯ��������</param>
        /// <returns></returns>
        public static void SqlAddArr(string SqlStr, string ValStr, ref StringBuilder Str, ref List<string> ArrStr)
        {
            SqlAddArr(SqlStr, ValStr, " and ", ref Str, ref ArrStr);
        }

        /// <summary>�ϲ�Sql��䲢���Sql��ѯ��������</summary>
        /// <param name="SqlStr">��Ҫ�ϲ���Sql���</param>
        /// <param name="Str">��Ҫ���²������Sql���</param>
        /// <param name="ArrStr">��Ҫ���²������Sql��ѯ��������</param>
        /// <param name="JoStr">Sql�ϲ�ʱ���������</param>
        /// <param name="Params">��Ҫ��ӵ�params�ɱ��������</param>
        /// <returns></returns>
        public static void SqlAddArr(string SqlStr, string JoStr, ref StringBuilder Str, ref List<string> ArrStr, params string[] Params)
        {
            if (Str.Length > 0)
            {
                Str.Append(JoStr);
            }
            Str.Append(SqlStr);
            for (int i = 0; i < Params.Length; i++)
            {
                ArrStr.Add(Params[i]);
            }
        }

        /// <summary>�ϲ�Sql��䲢���Sql��ѯ��������</summary>
        /// <param name="SqlStr">��Ҫ�ϲ���Sql���</param>
        /// <param name="Str">��Ҫ���²������Sql���</param>
        /// <param name="ArrStr">��Ҫ���²������Sql��ѯ��������</param>
        /// <param name="Params">��Ҫ��ӵ�params�ɱ��������</param>
        /// <returns></returns>
        public static void SqlAddArr(string SqlStr, ref StringBuilder Str, ref List<string> ArrStr, params string[] Params)
        {
            SqlAddArr(SqlStr, " and ", ref Str, ref ArrStr, Params);
        }

        /// <summary>���Sql��䳤�ȴ���0��������ǰ����� where</summary>
        /// <param name="Str">��Ҫ���²������Sql���</param>
        /// <returns></returns>
        public static void SqlAddWhere(ref StringBuilder Str)
        {
            if (Str.Length > 0)
            {
                SqlAddSql(ref Str, " where ");
            }
        }

        /// <summary>���Sql��䳤�ȴ���0��������ǰ�����ָ���ַ���</summary>
        /// <param name="Str">��Ҫ���²������Sql���</param>
        /// <param name="iStr">��Ҫ������ַ���</param>
        /// <returns></returns>
        public static void SqlAddSql(ref StringBuilder Str, string iStr)
        {
            if (Str.Length > 0)
            {
                Str.Insert(0, iStr);
            }
        }

        /// <summary>׷��ָ��Sql���,���Sql��䳤�ȴ���0��������ǰ�����ָ���ַ���</summary>
        /// <param name="Str">��Ҫ���²������Sql���</param>
        /// <param name="addStr">��Ҫ׷�ӵ�Sql���</param>
        /// <param name="inStr">��Ҫ������ַ���</param>
        /// <returns></returns>
        public static void SqlAddSql(ref StringBuilder Str, string addStr, string inStr)
        {
            if (Str.Length > 0)
            {
                Str.Append(inStr);
            }
            Str.Append(addStr);
        }

        #endregion

        #region ��ȡDataTable��ĳ�е�ֵ����ɾ����ֵ���ҿհס�������в������򷵻ؿ��ַ���

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(DataTable DT, string ColName)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                if (DT.Rows.Count > 0)
                {
                    return DT.Rows[0][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(DataTable DT, int ColIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                if (DT.Rows.Count > 0)
                {
                    return DT.Rows[0][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(DataTable DT, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                if (DT.Rows.Count > RowIndex && RowIndex > -1)
                {
                    return DT.Rows[RowIndex][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(DataTable DT, int ColIndex, int RowIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                if (DT.Rows.Count > RowIndex && RowIndex > -1)
                {
                    return DT.Rows[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, DataTable DT, string ColName)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, DataTable DT, int ColIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, DataTable DT, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, DataTable DT, int ColIndex, int RowIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataTable DT, string ColName)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataTable DT, int ColIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataTable DT, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataTable DT, int ColIndex, int RowIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex, int RowIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        #endregion

        #region ��ȡDataTable��ĳ�е�ֵ��������в������򷵻ؿ��ַ���

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(DataTable DT, string ColName)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                if (DT.Rows.Count > 0)
                {
                    return DT.Rows[0][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(DataTable DT, int ColIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                if (DT.Rows.Count > 0)
                {
                    return DT.Rows[0][ColIndex].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(DataTable DT, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                if (DT.Rows.Count > RowIndex && RowIndex > -1)
                {
                    return DT.Rows[RowIndex][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(DataTable DT, int ColIndex, int RowIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                if (DT.Rows.Count > RowIndex && RowIndex > -1)
                {
                    return DT.Rows[RowIndex][ColIndex].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, DataTable DT, string ColName)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, DataTable DT, int ColIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, DataTable DT, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, DataTable DT, int ColIndex, int RowIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataTable DT, string ColName)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataTable DT, int ColIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataTable DT, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataTable DT, int ColIndex, int RowIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex, int RowIndex)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString();
                }
            }
            return "";
        }

        #endregion

        #region ��ȡDataTable��ĳ�е�ֵ����ɾ����ֵ���ҿհס�������в������򷵻�ָ���ַ���

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(DataTable DT, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                if (DT.Rows.Count > 0)
                {
                    return DT.Rows[0][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(DataTable DT, int ColIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                if (DT.Rows.Count > 0)
                {
                    return DT.Rows[0][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(DataTable DT, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                if (DT.Rows.Count > RowIndex && RowIndex > -1)
                {
                    return DT.Rows[RowIndex][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(DataTable DT, int ColIndex, int RowIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                if (DT.Rows.Count > RowIndex && RowIndex > -1)
                {
                    return DT.Rows[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, DataTable DT, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, DataTable DT, int ColIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, DataTable DT, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, DataTable DT, int ColIndex, int RowIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataTable DT, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataTable DT, int ColIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataTable DT, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataTable DT, int ColIndex, int RowIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStr(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex, int RowIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        #endregion

        #region ��ȡDataTable��ĳ�е�ֵ��������в������򷵻�ָ���ַ���

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(DataTable DT, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                if (DT.Rows.Count > 0)
                {
                    return DT.Rows[0][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(DataTable DT, int ColIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                if (DT.Rows.Count > 0)
                {
                    return DT.Rows[0][ColIndex].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(DataTable DT, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                if (DT.Rows.Count > RowIndex && RowIndex > -1)
                {
                    return DT.Rows[RowIndex][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(DataTable DT, int ColIndex, int RowIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                if (DT.Rows.Count > RowIndex && RowIndex > -1)
                {
                    return DT.Rows[RowIndex][ColIndex].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, DataTable DT, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, DataTable DT, int ColIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, DataTable DT, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, DataTable DT, int ColIndex, int RowIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataTable DT, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataTable DT, int ColIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataTable DT, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataTable DT, int ColIndex, int RowIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > 0)
                {
                    return dRow[0][ColIndex].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (DT.Columns.Contains(ColName))
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex, int RowIndex, string defStr)
        {
            if (DT.Columns.Count > ColIndex && ColIndex > -1)
            {
                DataRow[] dRow = DT.Select(filter, sort, dvrs);
                if (dRow.Length > RowIndex && RowIndex > -1)
                {
                    return dRow[RowIndex][ColIndex].ToString();
                }
            }
            return defStr;
        }

        #endregion

        #region ��ȡDataRow��ĳ�е�ֵ����ɾ����ֵ���ҿհס�������в������򷵻ؿ��ַ���

        /// <summary>��ȡDataRowָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStr(DataRow dr, string ColName)
        {
            ColName = ColName.Trim();
            if (dr.Table.Columns.Contains(ColName))
            {
                return dr[ColName].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataRowָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStr(DataRow dr, int ColIndex)
        {
            if (dr.Table.Columns.Count > ColIndex && ColIndex > -1)
            {
                return dr[ColIndex].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataRow�����һ��ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStr(DataRow[] dr, string ColName)
        {
            ColName = ColName.Trim();
            if (dr.Length > 0)
            {
                if (dr[0].Table.Columns.Contains(ColName))
                {
                    return dr[0][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataRow�����һ��ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStr(DataRow[] dr, int ColIndex)
        {
            if (dr.Length > 0)
            {
                if (dr[0].Table.Columns.Count > ColIndex && ColIndex > -1)
                {
                    return dr[0][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataRow����ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ָ���е�ֵ</returns>
        public static string GetStr(DataRow[] dr, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                if (dr[RowIndex].Table.Columns.Contains(ColName))
                {
                    return dr[RowIndex][ColName].ToString().Trim();
                }
            }
            return "";
        }

        /// <summary>��ȡDataRow����ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ָ����������ֵ</returns>
        public static string GetStr(DataRow[] dr, int ColIndex, int RowIndex)
        {
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                if (dr[RowIndex].Table.Columns.Count > ColIndex && ColIndex > -1)
                {
                    return dr[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return "";
        }

        #endregion

        #region ��ȡDataRow��ĳ�е�ֵ����ɾ����ֵ���ҿհס�������в������򷵻�ָ���ַ���

        /// <summary>��ȡDataRowָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStr(DataRow dr, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (dr.Table.Columns.Contains(ColName))
            {
                return dr[ColName].ToString().Trim();
            }
            return defStr;
        }

        /// <summary>��ȡDataRowָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStr(DataRow dr, int ColIndex, string defStr)
        {
            if (dr.Table.Columns.Count > ColIndex && ColIndex > -1)
            {
                return dr[ColIndex].ToString().Trim();
            }
            return defStr;
        }

        /// <summary>��ȡDataRow�����һ��ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStr(DataRow[] dr, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (dr.Length > 0)
            {
                if (dr[0].Table.Columns.Contains(ColName))
                {
                    return dr[0][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataRow�����һ��ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStr(DataRow[] dr, int ColIndex, string defStr)
        {
            if (dr.Length > 0)
            {
                if (dr[0].Table.Columns.Count > ColIndex && ColIndex > -1)
                {
                    return dr[0][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataRow����ָ���е�ָ���е�ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ָ���е�ֵ</returns>
        public static string GetStr(DataRow[] dr, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                if (dr[RowIndex].Table.Columns.Contains(ColName))
                {
                    return dr[RowIndex][ColName].ToString().Trim();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataRow����ָ���е�ָ����������ֵ����ɾ�����ҿհס����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ָ����������ֵ</returns>
        public static string GetStr(DataRow[] dr, int ColIndex, int RowIndex, string defStr)
        {
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                if (dr[RowIndex].Table.Columns.Count > ColIndex && ColIndex > -1)
                {
                    return dr[RowIndex][ColIndex].ToString().Trim();
                }
            }
            return defStr;
        }

        #endregion

        #region ��ȡDataRow��ĳ�е�ֵ��������в������򷵻ؿ��ַ���

        /// <summary>��ȡDataRowָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStrs(DataRow dr, string ColName)
        {
            ColName = ColName.Trim();
            if (dr.Table.Columns.Contains(ColName))
            {
                return dr[ColName].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataRowָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStrs(DataRow dr, int ColIndex)
        {
            if (dr.Table.Columns.Count > ColIndex && ColIndex > -1)
            {
                return dr[ColIndex].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataRow�����һ��ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStrs(DataRow[] dr, string ColName)
        {
            ColName = ColName.Trim();
            if (dr.Length > 0)
            {
                if (dr[0].Table.Columns.Contains(ColName))
                {
                    return dr[0][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataRow�����һ��ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStrs(DataRow[] dr, int ColIndex)
        {
            if (dr.Length > 0)
            {
                if (dr[0].Table.Columns.Count > ColIndex && ColIndex > -1)
                {
                    return dr[0][ColIndex].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataRow����ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(DataRow[] dr, string ColName, int RowIndex)
        {
            ColName = ColName.Trim();
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                if (dr[RowIndex].Table.Columns.Contains(ColName))
                {
                    return dr[RowIndex][ColName].ToString();
                }
            }
            return "";
        }

        /// <summary>��ȡDataRow����ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻ؿ��ַ���</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ָ����������ֵ</returns>
        public static string GetStrs(DataRow[] dr, int ColIndex, int RowIndex)
        {
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                if (dr[RowIndex].Table.Columns.Count > ColIndex && ColIndex > -1)
                {
                    return dr[RowIndex][ColIndex].ToString();
                }
            }
            return "";
        }

        #endregion

        #region ��ȡDataRow��ĳ�е�ֵ��������в������򷵻�ָ���ַ���

        /// <summary>��ȡDataRowָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStrs(DataRow dr, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (dr.Table.Columns.Contains(ColName))
            {
                return dr[ColName].ToString();
            }
            return defStr;
        }

        /// <summary>��ȡDataRowָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStrs(DataRow dr, int ColIndex, string defStr)
        {
            if (dr.Table.Columns.Count > ColIndex && ColIndex > -1)
            {
                return dr[ColIndex].ToString();
            }
            return defStr;
        }

        /// <summary>��ȡDataRow�����һ��ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStrs(DataRow[] dr, string ColName, string defStr)
        {
            ColName = ColName.Trim();
            if (dr.Length > 0)
            {
                if (dr[0].Table.Columns.Contains(ColName))
                {
                    return dr[0][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataRow�����һ��ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetStrs(DataRow[] dr, int ColIndex, string defStr)
        {
            if (dr.Length > 0)
            {
                if (dr[0].Table.Columns.Count > ColIndex && ColIndex > -1)
                {
                    return dr[0][ColIndex].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataRow����ָ���е�ָ���е�ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ָ���е�ֵ</returns>
        public static string GetStrs(DataRow[] dr, string ColName, int RowIndex, string defStr)
        {
            ColName = ColName.Trim();
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                if (dr[RowIndex].Table.Columns.Contains(ColName))
                {
                    return dr[RowIndex][ColName].ToString();
                }
            }
            return defStr;
        }

        /// <summary>��ȡDataRow����ָ���е�ָ����������ֵ�����û���ҵ�ָ�������򷵻�ָ���ַ���</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <param name="defStr">Ĭ��ֵ</param>
        /// <returns>����DataRowָ���е�ָ����������ֵ</returns>
        public static string GetStrs(DataRow[] dr, int ColIndex, int RowIndex, string defStr)
        {
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                if (dr[RowIndex].Table.Columns.Count > ColIndex && ColIndex > -1)
                {
                    return dr[RowIndex][ColIndex].ToString();
                }
            }
            return defStr;
        }

        #endregion

        #region ��ȡDataTable��ĳ�е�ֵ����ɾ����ֵ���ҿհס�������в�������������

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVal(DataTable DT, string ColName)
        {
            return DT.Rows[0][ColName.Trim()].ToString().Trim();
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVal(DataTable DT, int ColIndex)
        {
            return DT.Rows[0][ColIndex].ToString().Trim();
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVal(DataTable DT, string ColName, int RowIndex)
        {
            return DT.Rows[RowIndex][ColName.Trim()].ToString().Trim();
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVal(DataTable DT, int ColIndex, int RowIndex)
        {
            return DT.Rows[RowIndex][ColIndex].ToString().Trim();
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, DataTable DT, string ColName)
        {
            DataRow[] dRow = DT.Select(filter);
            if (dRow.Length > 0)
            {
                return dRow[0][ColName.Trim()].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, DataTable DT, int ColIndex)
        {
            DataRow[] dRow = DT.Select(filter);
            if (dRow.Length > 0)
            {
                return dRow[0][ColIndex].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, DataTable DT, string ColName, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColName.Trim()].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, DataTable DT, int ColIndex, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColIndex].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, string sort, DataTable DT, string ColName)
        {
            DataRow[] dRow = DT.Select(filter, sort);
            if (dRow.Length > 0)
            {
                return dRow[0][ColName.Trim()].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, string sort, DataTable DT, int ColIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort);
            if (dRow.Length > 0)
            {
                return dRow[0][ColIndex].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, string sort, DataTable DT, string ColName, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColName.Trim()].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, string sort, DataTable DT, int ColIndex, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColIndex].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName)
        {
            DataRow[] dRow = DT.Select(filter, sort, dvrs);
            if (dRow.Length > 0)
            {
                return dRow[0][ColName.Trim()].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort, dvrs);
            if (dRow.Length > 0)
            {
                return dRow[0][ColIndex].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort, dvrs);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColName.Trim()].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVal(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort, dvrs);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColIndex].ToString().Trim();
            }
            return "";
        }

        #endregion

        #region ��ȡDataTable��ĳ�е�ֵ��������в�������������

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ��</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVals(DataTable DT, string ColName)
        {
            return DT.Rows[0][ColName.Trim()].ToString();
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ��</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVals(DataTable DT, int ColIndex)
        {
            return DT.Rows[0][ColIndex].ToString();
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ��</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVals(DataTable DT, string ColName, int RowIndex)
        {
            return DT.Rows[RowIndex][ColName.Trim()].ToString();
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ��</summary>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVals(DataTable DT, int ColIndex, int RowIndex)
        {
            return DT.Rows[RowIndex][ColIndex].ToString();
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, DataTable DT, string ColName)
        {
            DataRow[] dRow = DT.Select(filter);
            if (dRow.Length > 0)
            {
                return dRow[0][ColName.Trim()].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, DataTable DT, int ColIndex)
        {
            DataRow[] dRow = DT.Select(filter);
            if (dRow.Length > 0)
            {
                return dRow[0][ColIndex].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, DataTable DT, string ColName, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColName.Trim()].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, DataTable DT, int ColIndex, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColIndex].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, string sort, DataTable DT, string ColName)
        {
            DataRow[] dRow = DT.Select(filter, sort);
            if (dRow.Length > 0)
            {
                return dRow[0][ColName.Trim()].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, string sort, DataTable DT, int ColIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort);
            if (dRow.Length > 0)
            {
                return dRow[0][ColIndex].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, string sort, DataTable DT, string ColName, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColName.Trim()].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, string sort, DataTable DT, int ColIndex, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColIndex].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ���е�ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName)
        {
            DataRow[] dRow = DT.Select(filter, sort, dvrs);
            if (dRow.Length > 0)
            {
                return dRow[0][ColName.Trim()].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵĵ�һ�е�ָ����������ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataTable�ڵĵ�һ�е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort, dvrs);
            if (dRow.Length > 0)
            {
                return dRow[0][ColIndex].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ���е�ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, string sort, DataViewRowState dvrs, DataTable DT, string ColName, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort, dvrs);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColName.Trim()].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataTable�ڵ�ָ���е�ָ����������ֵ��</summary>
        /// <param name="filter">Ҫ����ɸѡ�е�����</param>
        /// <param name="sort">һ���ַ�������ָ���к�������</param>
        /// <param name="dvrs">DataViewRowState ֵ֮һ</param>
        /// <param name="DT">һ��DataTableʵ��������</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataTable�ڵ�ָ���е�ָ���е�ֵ</returns>
        public static string GetVals(string filter, string sort, DataViewRowState dvrs, DataTable DT, int ColIndex, int RowIndex)
        {
            DataRow[] dRow = DT.Select(filter, sort, dvrs);
            if (dRow.Length > RowIndex && RowIndex > -1)
            {
                return dRow[RowIndex][ColIndex].ToString();
            }
            return "";
        }

        #endregion

        #region ��ȡDataRow��ĳ�е�ֵ����ɾ����ֵ���ҿհס�������в�������������

        /// <summary>��ȡDataRowָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetVal(DataRow dr, string ColName)
        {
            return dr[ColName.Trim()].ToString().Trim();
        }

        /// <summary>��ȡDataRowָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetVal(DataRow dr, int ColIndex)
        {
            return dr[ColIndex].ToString().Trim();
        }

        /// <summary>��ȡDataRow�����һ��ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetVal(DataRow[] dr, string ColName)
        {
            if (dr.Length > 0)
            {
                return dr[0][ColName.Trim()].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataRow�����һ��ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetVal(DataRow[] dr, int ColIndex)
        {
            if (dr.Length > 0)
            {
                return dr[0][ColIndex].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataRow����ָ���е�ָ���е�ֵ����ɾ�����ҿհס�</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ָ���е�ֵ</returns>
        public static string GetVal(DataRow[] dr, string ColName, int RowIndex)
        {
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                return dr[RowIndex][ColName.Trim()].ToString().Trim();
            }
            return "";
        }

        /// <summary>��ȡDataRow����ָ���е�ָ����������ֵ����ɾ�����ҿհס�</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ָ����������ֵ</returns>
        public static string GetVal(DataRow[] dr, int ColIndex, int RowIndex)
        {
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                return dr[RowIndex][ColIndex].ToString().Trim();
            }
            return "";
        }

        #endregion

        #region ��ȡDataRow��ĳ�е�ֵ��������в�������������

        /// <summary>��ȡDataRowָ���е�ֵ��</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetVals(DataRow dr, string ColName)
        {
            return dr[ColName.Trim()].ToString();
        }

        /// <summary>��ȡDataRowָ����������ֵ��</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetVals(DataRow dr, int ColIndex)
        {
            return dr[ColIndex].ToString();
        }

        /// <summary>��ȡDataRow�����һ��ָ���е�ֵ��</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColName">����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetVals(DataRow[] dr, string ColName)
        {
            if (dr.Length > 0)
            {
                return dr[0][ColName.Trim()].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataRow�����һ��ָ����������ֵ��</summary>
        /// <param name="dr">һ��DataRow</param>
        /// <param name="ColIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ֵ</returns>
        public static string GetVals(DataRow[] dr, int ColIndex)
        {
            if (dr.Length > 0)
            {
                return dr[0][ColIndex].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataRow����ָ���е�ָ���е�ֵ��</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColName">����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ָ���е�ֵ</returns>
        public static string GetVals(DataRow[] dr, string ColName, int RowIndex)
        {
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                return dr[RowIndex][ColName.Trim()].ToString();
            }
            return "";
        }

        /// <summary>��ȡDataRow����ָ���е�ָ����������ֵ��</summary>
        /// <param name="dr">һ��DataRow����</param>
        /// <param name="ColIndex">�е�����</param>
        /// <param name="RowIndex">�е�����</param>
        /// <returns>����DataRowָ���е�ָ����������ֵ</returns>
        public static string GetVals(DataRow[] dr, int ColIndex, int RowIndex)
        {
            if (dr.Length > RowIndex && RowIndex > -1)
            {
                return dr[RowIndex][ColIndex].ToString();
            }
            return "";
        }

        #endregion

        #region DataTable���ò�������

        /// <summary>�����������б���ָ������ֵ,���δ�ҵ�ָ�������򷵻�-1</summary>
        /// <param name="li">�б�</param>
        /// <param name="index">����</param>
        /// <returns>�����������б���ָ������ֵ</returns>
        public static int GetIntListVal(List<int> li, int index)
        {
            if (index < li.Count)
            {
                return li[index];
            }
            return -1;
        }

        /// <summary>��һ��DataTable���뵽DataSet�ڲ�����</summary>
        /// <param name="dt">һ��DataTable</param>
        /// <param name="tableName">DataTable����</param>
        /// <returns>����һ��DataSet</returns>
        public static DataSet GetDataSet(DataTable dt, string tableName)
        {
            DataSet Ds = new DataSet();
            Ds.Tables.Add(dt);
            Ds.Tables[0].TableName = tableName;
            return Ds;
        }

        /// <summary>��һ��DataTable���뵽DataSet�ڲ�����</summary>
        /// <param name="dt">һ��DataTable</param>
        /// <returns>����һ��DataSet</returns>
        public static DataSet GetDataSet(DataTable dt)
        {
            DataSet Ds = new DataSet();
            Ds.Tables.Add(dt);
            return Ds;
        }

        /// <summary>����DataRow���鷵��ָ���ڴ���ܵ�DataTable</summary>
        /// <param name="drs">DataRow����</param>
        /// <param name="dt">��Ҫ�������ܵ��ڴ��</param>
        /// <returns>�������������鷵��DataTable</returns>
        public static DataTable GetTable(DataRow[] drs, DataTable dt)
        {
            DataTable ndt = new DataTable();
            ndt = dt.Clone();
            for (int i = 0; i < drs.Length; i++)
            {
                ndt.ImportRow(drs[i]);
            }
            return ndt;
        }

        /// <summary>����DataRow���鷵��DataTable</summary>
        /// <param name="drs">DataRow����</param>
        /// <returns>�������������鷵��DataTable</returns>
        public static DataTable GetTable(DataRow[] drs)
        {
            DataTable ndt = new DataTable();
            if (drs.Length > 0) 
            {
                ndt = drs[0].Table.Clone();
                for (int i = 0; i < drs.Length; i++)
                {
                    ndt.ImportRow(drs[i]);
                }
            }
            return ndt;
        }

        /// <summary>��DataRow���鿽����ָ���ڴ���ܵ�DataTable</summary>
        /// <param name="drs">DataRow����</param>
        /// <param name="cdt">��Ҫ�������ݵ��ڴ��</param>
        /// <param name="dt">��Ҫ�������ܵ��ڴ��</param>
        public static void CopyTable(DataRow[] drs, DataTable cdt, DataTable dt)
        {
            cdt = dt.Clone();
            for (int i = 0; i < drs.Length; i++)
            {
                cdt.ImportRow(drs[i]);
            }
        }

        /// <summary>��ָ����DataTable�ڵ����ݺ͹��ܿ�����ָ���ڴ��</summary>
        /// <param name="dt">��Ҫ�������ܵ��ڴ��</param>
        /// <param name="cdt">��Ҫ�������ݵ��ڴ��</param>
        public static void CopyTable(DataTable dt, DataTable cdt)
        {
            cdt = dt.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cdt.ImportRow(dt.Rows[i]);
            }
        }

        /// <summary>��ָ����DataView�ڵ����ݺ͹��ܿ�����ָ���ڴ��</summary>
        /// <param name="dv">��Ҫ�������ݺ͹��ܵ�DataView</param>
        /// <param name="cdt">��Ҫ�������ݵ��ڴ��</param>
        public static void CopyTable(DataView dv, DataTable cdt)
        {
            cdt = dv.Table.Clone();
            for (int i = 0; i < dv.Count; i++)
            {
                cdt.ImportRow(dv[i].Row);
            }
        }

        /// <summary>����ָ���ڴ���ظ�id����</summary>
        /// <param name="rdt">����id�ֶε��ڴ��</param>
        /// <param name="idName">id�ֶ�����</param>
        /// <returns>����ָ���ڴ���ظ�id����</returns>
        public static string GetIds(DataTable rdt, string idName)
        {
            StringBuilder sb = new StringBuilder();
            List<string> ls = new List<string>();
            for (int i = 0; i < rdt.Rows.Count; i++)
            {
                string idstr = rdt.Rows[i][idName.Trim()].ToString().Trim();
                if (idstr != "" && ls.IndexOf(idstr) == -1)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(",");
                    }
                    sb.Append(idstr);
                    ls.Add(idstr);
                }
            }
            return sb.ToString();
        }

        /// <summary>����ָ���ڴ���ظ��û�������</summary>
        /// <param name="rdt">�����û����ֶε��ڴ��</param>
        /// <param name="idName">�û����ֶ�����</param>
        /// <returns>����ָ���ڴ���ظ��û�������</returns>
        public static string GetUsers(DataTable rdt, string idName)
        {
            StringBuilder sb = new StringBuilder();
            List<string> ls = new List<string>();
            for (int i = 0; i < rdt.Rows.Count; i++)
            {
                string idstr = "'" + rdt.Rows[i][idName.Trim()].ToString().Trim() + "'";
                if (idstr != "" && ls.IndexOf(idstr) == -1)
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(",");
                    }
                    sb.Append(idstr);
                    ls.Add(idstr);
                }
            }
            return sb.ToString();
        }

        /// <summary>����ָ����������ʽ������������ڴ��</summary>
        /// <param name="sdt">��Ҫ������ڴ��</param>
        /// <param name="sorts">������ʽ</param>
        /// <returns>����ָ�������򷽷�������������ڴ��</returns>
        public static DataTable GetSortTable(DataTable sdt, string sorts)
        {
            DataView dv = sdt.DefaultView;
            dv.Sort = sorts;
            return dv.ToTable();
        }

        #endregion
    }
}

