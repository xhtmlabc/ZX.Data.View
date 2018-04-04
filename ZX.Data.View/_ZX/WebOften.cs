using System;
using System.Text;
using System.Net;
using System.Data;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Configuration;

namespace App
{
    /// <summary>Web���þ�̬����������</summary>
    [Serializable]
    public static class WebOften
    {

        #region WEB���÷���

        /// <summary>���ַ�������DataTable��,�����ʹ�� || �ָ� ֵ���ı�ʹ�� | �ָ�(DataTable���� 0:value,1:text)</summary>
        /// <param name="Str">DataTable ���ݱ��ַ���</param>
        /// <returns>����DataTable��</returns>
        public static DataTable StrToDataTable(string Str)
        {
            return StrToDataTable(Str, "||", "|");
        }

        /// <summary>���ַ�������DataTable��(DataTable���� 0:value,1:text)</summary>
        /// <param name="Str">DataTable ���ݱ��ַ���</param>
        /// <param name="groupCompart">�����ķָ��ַ���</param>
        /// <param name="compart">ֵ���ı��ķָ��ַ���</param>
        /// <returns>����DataTable��</returns>
        public static DataTable StrToDataTable(string Str, string groupCompart, string compart)
        {
            DataTable DT = new DataTable();
            DT.Columns.Add("value", Type.GetType("System.String"));
            DT.Columns.Add("text", Type.GetType("System.String"));
            string[] sArray = Regex.Split(Str, App.Often.GetRegStr(groupCompart), RegexOptions.IgnoreCase);
            for (int i = 0; i < sArray.Length; i++)
            {
                string stra = sArray[i].Trim();
                if (stra != "")
                {
                    string[] xArray = Regex.Split(stra, App.Often.GetRegStr(compart), RegexOptions.IgnoreCase);
                    if (xArray.Length > 1)
                    {
                        DataRow newRow = DT.NewRow();
                        newRow["value"] = xArray[0].Trim();
                        newRow["text"] = xArray[1].Trim();
                        DT.Rows.Add(newRow);
                    }
                }
            }
            return DT;
        }

        /// <summary>������ֵ���ı�����ɵ�DataTable�ַ�����ѡ���е��ı�</summary>
        /// <param name="Str">DataTable ���ݱ��ַ��� �ַ�����ʽ�������ʹ�� || �ָ� ֵ���ı�ʹ�� | �ָ�</param>
        /// <param name="selValue">ѡ�е�ֵ</param>
        /// <returns>������ֵ���ı�����ɵ�DataTable�ַ�����ѡ���е��ı�</returns>
        public static string GetListVal(string Str, string selValue)
        {
            return GetListVal(StrToDataTable(Str, "||", "|"), selValue, 0, 1);
        }

        /// <summary>������ֵ���ı�����ɵ�DataTable�ַ�����ѡ���е��ı�</summary>
        /// <param name="Str">DataTable ���ݱ��ַ��� �ַ�����ʽ�������ʹ�� || �ָ� ֵ���ı�ʹ�� | �ָ�</param>
        /// <param name="selValue">ѡ�е�ֵ</param>
        /// <param name="valueIndex">ѡ���е�����</param>
        /// <returns>������ֵ���ı�����ɵ�DataTable�ַ�����ѡ���е��ı�</returns>
        public static string GetListVal(string Str, string selValue, int valueIndex)
        {
            return GetListVal(StrToDataTable(Str, "||", "|"), selValue, valueIndex, 1);
        }

        /// <summary>������ֵ���ı�����ɵ�DataTable�ַ�����ѡ���е��ı�</summary>
        /// <param name="Str">DataTable ���ݱ��ַ��� �ַ�����ʽ�������ʹ�� || �ָ� ֵ���ı�ʹ�� | �ָ�</param>
        /// <param name="selValue">ѡ�е�ֵ</param>
        /// <param name="valueIndex">ѡ���е�����</param>
        /// <param name="textIndex">�ı��е�����</param>
        /// <returns>������ֵ���ı�����ɵ�DataTable�ַ�����ѡ���е��ı�</returns>
        public static string GetListVal(string Str, string selValue, int valueIndex, int textIndex)
        {
            return GetListVal(StrToDataTable(Str, "||", "|"), selValue, valueIndex, textIndex);
        }

        /// <summary>������ֵ���ı�����ɵ�DataTable�ַ�����ѡ���е��ı�</summary>
        /// <param name="Str">DataTable ���ݱ��ַ���</param>
        /// <param name="selValue">ѡ�е�ֵ</param>
        /// <param name="valueIndex">ѡ���е�����</param>
        /// <param name="textIndex">�ı��е�����</param>
        /// <param name="groupCompart">�����ķָ��ַ���</param>
        /// <param name="compart">ֵ���ı��ķָ��ַ���</param>
        /// <returns>������ֵ���ı�����ɵ�DataTable�ַ�����ѡ���е��ı�</returns>
        public static string GetListVal(string Str, string selValue, int valueIndex, int textIndex, string groupCompart, string compart)
        {
            return GetListVal(StrToDataTable(Str, groupCompart, compart), selValue, valueIndex, textIndex);
        }

        /// <summary>������ֵ���ı�����ɵ�DataTable��ѡ���е��ı�</summary>
        /// <param name="DT">��ֵ���ı�����ɵ�DataTable ���ݱ�(DataTable���� 0:value,1:text)</param>
        /// <param name="selValue">ѡ�е�ֵ</param>
        /// <returns>������ֵ���ı�����ɵ�DataTable��ѡ���е��ı�</returns>
        public static string GetListVal(DataTable DT, string selValue)
        {
            return GetListVal(DT, selValue, 0, 1);
        }

        /// <summary>������ֵ���ı�����ɵ�DataTable��ѡ���е��ı�</summary>
        /// <param name="DT">��ֵ���ı�����ɵ�DataTable ���ݱ�(DataTable���� 0:value,1:text)</param>
        /// <param name="selValue">ѡ�е�ֵ</param>
        /// <param name="valueIndex">ѡ���е�����</param>
        /// <returns>������ֵ���ı�����ɵ�DataTable��ѡ���е��ı�</returns>
        public static string GetListVal(DataTable DT, string selValue, int valueIndex)
        {
            return GetListVal(DT, selValue, valueIndex, 1);
        }

        /// <summary>������ֵ���ı�����ɵ�DataTable��ѡ���е��ı�</summary>
        /// <param name="DT">��ֵ���ı�����ɵ�DataTable ���ݱ�(DataTable���� 0:value,1:text)</param>
        /// <param name="selValue">ѡ�е�ֵ</param>
        /// <param name="valueIndex">ѡ���е�����</param>
        /// <param name="textIndex">�ı��е�����</param>
        /// <returns>������ֵ���ı�����ɵ�DataTable��ѡ���е��ı�</returns>
        public static string GetListVal(DataTable DT, string selValue, int valueIndex, int textIndex)
        {
            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string val = DT.Rows[i][valueIndex].ToString().Trim();
                if (val == selValue.Trim())
                {
                    return DT.Rows[i][textIndex].ToString();
                }
            }
            return "";
        }

        #endregion
    }
}
