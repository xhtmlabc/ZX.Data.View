using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace App
{
    /// <summary>����ʱ�䳣�þ�̬������</summary>
    [Serializable]
    public static class DateOften
    {
        /// <summary>���ص�ǰ���������ڼ�(�����������ڣ�����һ�����ڶ����������������ġ������塢��������������)</summary> 
        /// <returns>���ص�ǰ���������ڼ�</returns>
        public static string DayToWeek()
        {
            return DayToWeek(DateTime.Now);
        }

        /// <summary>�����ַ�����ʽ�����ڷ��ظ����������ڼ�(�����������ڣ�����һ�����ڶ����������������ġ������塢��������������)</summary> 
        /// <param name="de">һ���ַ�����ʽ������</param>
        /// <returns>�������������ڼ�</returns>
        public static string DayToWeek(string de)
        {
            if (Often.IsDate(de))
            {
                return DayToWeek(Convert.ToDateTime(de));
            }
            return "";
        }

        /// <summary>�������ڷ��ظ����������ڼ�(�����������ڣ�����һ�����ڶ����������������ġ������塢��������������)</summary> 
        /// <param name="de">һ������</param>
        /// <returns>�������������ڼ�</returns>
        public static string DayToWeek(DateTime de)
        {
            if (de.DayOfWeek == DayOfWeek.Monday)
            {
                return "����һ";
            }
            if (de.DayOfWeek == DayOfWeek.Tuesday)
            {
                return "���ڶ�";
            }
            if (de.DayOfWeek == DayOfWeek.Wednesday)
            {
                return "������";
            }
            if (de.DayOfWeek == DayOfWeek.Thursday)
            {
                return "������";
            }
            if (de.DayOfWeek == DayOfWeek.Friday)
            {
                return "������";
            }
            if (de.DayOfWeek == DayOfWeek.Saturday)
            {
                return "������";
            }
            return "������";
        }

        /// <summary>�������ںͲ����г������ڷ��ظ����������ڼ�(�ڶ�������ֵ�����ǣ�1234567�����磺524�������������ڣ�����һ�����ڶ����������������ġ������塢��������������)</summary> 
        /// <param name="de">һ������</param>
        /// <param name="sd">ֻ���ظò����г������ڣ�����ֵ�����ǣ�1234567�����磺524</param>
        /// <returns>�������������ڼ�</returns>
        public static string DayToWeek(DateTime de, string sd)
        {
            if (de.DayOfWeek == DayOfWeek.Monday)
            {
                if (sd.IndexOf("1") > -1)
                {
                    return "����һ";
                }
                else
                {
                    return "";
                }
            }
            if (de.DayOfWeek == DayOfWeek.Tuesday)
            {
                if (sd.IndexOf("2") > -1)
                {
                    return "���ڶ�";
                }
                else
                {
                    return "";
                }
            }
            if (de.DayOfWeek == DayOfWeek.Wednesday)
            {
                if (sd.IndexOf("3") > -1)
                {
                    return "������";
                }
                else
                {
                    return "";
                }
            }
            if (de.DayOfWeek == DayOfWeek.Thursday)
            {
                if (sd.IndexOf("4") > -1)
                {
                    return "������";
                }
                else
                {
                    return "";
                }
            }
            if (de.DayOfWeek == DayOfWeek.Friday)
            {
                if (sd.IndexOf("5") > -1)
                {
                    return "������";
                }
                else
                {
                    return "";
                }
            }
            if (de.DayOfWeek == DayOfWeek.Saturday)
            {
                if (sd.IndexOf("6") > -1)
                {
                    return "������";
                }
                else
                {
                    return "";
                }
            }
            if (sd.IndexOf("7") > -1)
            {
                return "������";
            }
            else
            {
                return "";
            }
        }

        /// <summary>���ص�ǰ���������ڼ�(�������֣�1��2��3��4��5��6��7)</summary> 
        /// <returns>���ص�ǰ���������ڼ�</returns>
        public static byte DayToNumWeek()
        {
            return DayToNumWeek(DateTime.Now);
        }

        /// <summary>�����ַ�����ʽ�����ڷ��ظ����������ڼ�(�������֣�1��2��3��4��5��6��7)</summary> 
        /// <param name="de">һ���ַ�����ʽ������</param>
        /// <returns>�������������ڼ�</returns>
        public static byte DayToNumWeek(string de)
        {
            return DayToNumWeek(Convert.ToDateTime(de));
        }

        /// <summary>�������ڷ��ظ����������ڼ�(�������֣�1��2��3��4��5��6��7)</summary> 
        /// <param name="de">һ������</param>
        /// <returns>�������������ڼ�</returns>
        public static byte DayToNumWeek(DateTime de)
        {
            if (de.DayOfWeek == DayOfWeek.Monday)
            {
                return 1;
            }
            if (de.DayOfWeek == DayOfWeek.Tuesday)
            {
                return 2;
            }
            if (de.DayOfWeek == DayOfWeek.Wednesday)
            {
                return 3;
            }
            if (de.DayOfWeek == DayOfWeek.Thursday)
            {
                return 4;
            }
            if (de.DayOfWeek == DayOfWeek.Friday)
            {
                return 5;
            }
            if (de.DayOfWeek == DayOfWeek.Saturday)
            {
                return 6;
            }
            return 7;
        }

        /// <summary>�������ںͲ����г������ڷ��ظ����������ڼ�(�ڶ�������ֵ�����ǣ�1234567�����磺524���������֣�1��2��3��4��5��6��7)</summary> 
        /// <param name="de">һ������</param>
        /// <param name="sd">ֻ���ظò����г������ڣ�����ֵ�����ǣ�1234567�����磺524</param>
        /// <returns>�������������ڼ�</returns>
        public static byte DayToNumWeek(DateTime de, string sd)
        {
            if (de.DayOfWeek == DayOfWeek.Monday)
            {
                if (sd.IndexOf("1") > -1)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            if (de.DayOfWeek == DayOfWeek.Tuesday)
            {
                if (sd.IndexOf("2") > -1)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            if (de.DayOfWeek == DayOfWeek.Wednesday)
            {
                if (sd.IndexOf("3") > -1)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
            if (de.DayOfWeek == DayOfWeek.Thursday)
            {
                if (sd.IndexOf("4") > -1)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
            if (de.DayOfWeek == DayOfWeek.Friday)
            {
                if (sd.IndexOf("5") > -1)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
            if (de.DayOfWeek == DayOfWeek.Saturday)
            {
                if (sd.IndexOf("6") > -1)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
            if (sd.IndexOf("7") > -1)
            {
                return 7;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>��������ת���ɱ�׼���ڸ�ʽ������ 2008��10��1�� 6ʱ33��50�� ��ʽ������ת���� 2008-10-1 6:33:50</summary> 
        /// <param name="strIn">Ҫת�����ַ���</param>
        /// <param name="mode">
        /// ת��ģʽ
        /// <para>0����Ӧ 2008��10��1�� ��ʽ</para>
        /// <para>1����Ӧ 2008��10��1�� 6ʱ33�� ��ʽ</para>
        /// <para>2����Ӧ 2008��10��1�� 6ʱ33��50�� ��ʽ</para>
        /// <para>3����Ӧ 2008-10-1 ��ʽ</para>
        /// </param>
        /// <returns>������ת���õ��ַ���</returns>
        public static string ChToDTime(string strIn, byte mode)
        {
            switch (mode)
            {
                case 0:
                    strIn = strIn.Replace("��", "-");
                    strIn = strIn.Replace("��", "-");
                    strIn = strIn.Replace("��", "");
                    break;
                case 1:
                    strIn = strIn.Replace("��", "-");
                    strIn = strIn.Replace("��", "-");
                    strIn = strIn.Replace("��", "");
                    strIn = strIn.Replace("ʱ", ":");
                    strIn = strIn.Replace("��", ":00");
                    break;
                case 2:
                    strIn = strIn.Replace("��", "-");
                    strIn = strIn.Replace("��", "-");
                    strIn = strIn.Replace("��", "");
                    strIn = strIn.Replace("ʱ", ":");
                    strIn = strIn.Replace("��", ":");
                    strIn = strIn.Replace("��", "");
                    break;
                case 3:
                    StringBuilder strB = new StringBuilder(strIn);
                    strIn = strB.Replace("-", "��", strIn.IndexOf("-"), 1).ToString();
                    strB = new StringBuilder(strIn);
                    strIn = strB.Replace("-", "��", strIn.IndexOf("-"), 1).ToString();
                    strIn += "��";
                    break;
            }
            return strIn;
        }

        /// <summary>����ָ����ʽ(yyyy-MM-dd HH:mm:ss)�ĵ�ǰϵͳ�����ַ�����ʾ</summary>
        /// <returns>�����Ѹ�ʽ�������ַ�����ʾ</returns>
        public static string GetDate()
        {
            return GetDate(DateTime.Now, "yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>����ָ����ʽ(yyyy-MM-dd HH:mm:ss)�������ַ�����ʾ</summary>
        /// <param name="dt">��Ҫ��ʽ��������</param>
        /// <returns>�����Ѹ�ʽ�������ַ�����ʾ</returns>
        public static string GetDate(DateTime dt)
        {
            return GetDate(dt, "yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>����ָ����ʽ(yyyy-MM-dd HH:mm:ss)�������ַ�����ʾ</summary>
        /// <param name="dt">��Ҫ��ʽ��������</param>
        /// <returns>�����Ѹ�ʽ�������ַ�����ʾ</returns>
        public static string GetDates(string dt)
        {
            return GetDate(dt, "yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>����ָ����ʽ�ĵ�ǰϵͳ�����ַ�����ʾ
        /// <para>���ø�ʽ�ַ���</para> 
        /// <para>gg ʱ�ڻ��Ԫ�����Ҫ���ø�ʽ�����ڲ����й�����ʱ�ڻ��Ԫ�ַ���������Ը�ģʽ��</para>  
        /// <para>y��%y ��������Ԫ����ݡ������������Ԫ�����С�� 10������ʾ������ǰ�������ݡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%y����</para>  
        /// <para>yy ��������Ԫ����ݡ������������Ԫ�����С�� 10������ʾ����ǰ�������ݡ�</para>
        /// <para>yyyy ������Ԫ����λ������ݡ�</para>
        /// <para>d��%d ���е�ĳһ�졣һλ��������û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%d����</para>  
        /// <para>dd ���е�ĳһ�졣һλ����������һ��ǰ���㡣</para>  
        /// <para>ddd ����ĳ�����д���ơ�</para>  
        /// <para>dddd ����ĳ�����������</para>  
        /// <para>M��%M �·����֡�һλ�����·�û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%M����</para>  
        /// <para>MM �·����֡�һλ�����·���һ��ǰ���㡣</para>  
        /// <para>MMM �·ݵ���д���ơ�</para>  
        /// <para>MMMM �·ݵ��������ơ�</para>  
        /// <para>h��%h 12 Сʱ�Ƶ�Сʱ��һλ����Сʱ��û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%h����</para>
        /// <para>hh 12 Сʱ�Ƶ�Сʱ��һλ����Сʱ����ǰ���㡣 </para>
        /// <para>H��%H 24 Сʱ�Ƶ�Сʱ��һλ����Сʱ��û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%H����</para>
        /// <para>HH 24 Сʱ�Ƶ�Сʱ��һλ����Сʱ����ǰ���㡣</para>
        /// <para>m��%m ���ӡ�һλ���ķ�����û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%m����</para>
        /// <para>mm ���ӡ�һλ���ķ�������һ��ǰ���㡣</para>
        /// <para>s��%s �롣һλ��������û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%s����</para>
        /// <para>ss �롣һλ����������һ��ǰ���㡣</para>
        /// <para>f��%f ���С������Ϊһλ���������ֱ��ضϡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%f����</para>
        /// <para>ff ���С������Ϊ��λ���������ֱ��ضϡ�</para>
        /// <para>fff ���С������Ϊ��λ���������ֱ��ضϡ�</para>
        /// <para>F��%F ʾ���С�����ֵ������Ч���֡����������Ϊ�㣬����ʾ�κ����ݡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%F����</para>
        /// <para>FF ��ʾ���С�����ֵ����������Ч���֡����ǣ�����ʾβ����㣨���������֣���</para>
        /// <para>FFF ��ʾ���С�����ֵ����������Ч���֡����ǣ�����ʾβ����㣨���������֣���</para>  
        /// </summary>
        /// <param name="format">��ʽ�ַ���</param>
        /// <returns>�����Ѹ�ʽ�������ַ�����ʾ</returns>
        public static string GetDate(string format)
        {
            return GetDate(DateTime.Now, format);
        }

        /// <summary>����ָ����ʽ�������ַ�����ʾ
        /// <para>���ø�ʽ�ַ���</para> 
        /// <para>gg ʱ�ڻ��Ԫ�����Ҫ���ø�ʽ�����ڲ����й�����ʱ�ڻ��Ԫ�ַ���������Ը�ģʽ��</para>  
        /// <para>y��%y ��������Ԫ����ݡ������������Ԫ�����С�� 10������ʾ������ǰ�������ݡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%y����</para>  
        /// <para>yy ��������Ԫ����ݡ������������Ԫ�����С�� 10������ʾ����ǰ�������ݡ�</para>
        /// <para>yyyy ������Ԫ����λ������ݡ�</para>
        /// <para>d��%d ���е�ĳһ�졣һλ��������û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%d����</para>  
        /// <para>dd ���е�ĳһ�졣һλ����������һ��ǰ���㡣</para>  
        /// <para>ddd ����ĳ�����д���ơ�</para>  
        /// <para>dddd ����ĳ�����������</para>  
        /// <para>M��%M �·����֡�һλ�����·�û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%M����</para>  
        /// <para>MM �·����֡�һλ�����·���һ��ǰ���㡣</para>  
        /// <para>MMM �·ݵ���д���ơ�</para>  
        /// <para>MMMM �·ݵ��������ơ�</para>  
        /// <para>h��%h 12 Сʱ�Ƶ�Сʱ��һλ����Сʱ��û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%h����</para>
        /// <para>hh 12 Сʱ�Ƶ�Сʱ��һλ����Сʱ����ǰ���㡣 </para>
        /// <para>H��%H 24 Сʱ�Ƶ�Сʱ��һλ����Сʱ��û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%H����</para>
        /// <para>HH 24 Сʱ�Ƶ�Сʱ��һλ����Сʱ����ǰ���㡣</para>
        /// <para>m��%m ���ӡ�һλ���ķ�����û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%m����</para>
        /// <para>mm ���ӡ�һλ���ķ�������һ��ǰ���㡣</para>
        /// <para>s��%s �롣һλ��������û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%s����</para>
        /// <para>ss �롣һλ����������һ��ǰ���㡣</para>
        /// <para>f��%f ���С������Ϊһλ���������ֱ��ضϡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%f����</para>
        /// <para>ff ���С������Ϊ��λ���������ֱ��ضϡ�</para>
        /// <para>fff ���С������Ϊ��λ���������ֱ��ضϡ�</para>
        /// <para>F��%F ʾ���С�����ֵ������Ч���֡����������Ϊ�㣬����ʾ�κ����ݡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%F����</para>
        /// <para>FF ��ʾ���С�����ֵ����������Ч���֡����ǣ�����ʾβ����㣨���������֣���</para>
        /// <para>FFF ��ʾ���С�����ֵ����������Ч���֡����ǣ�����ʾβ����㣨���������֣���</para>  
        /// </summary>
        /// <param name="dt">��Ҫ��ʽ��������</param>
        /// <param name="format">��ʽ�ַ���</param>
        /// <returns>�����Ѹ�ʽ�������ַ�����ʾ</returns>
        public static string GetDate(DateTime dt, string format)
        {
            return dt.ToString(format);
        }

        /// <summary>����ָ����ʽ�������ַ�����ʾ
        /// <para>���ø�ʽ�ַ���</para> 
        /// <para>gg ʱ�ڻ��Ԫ�����Ҫ���ø�ʽ�����ڲ����й�����ʱ�ڻ��Ԫ�ַ���������Ը�ģʽ��</para>  
        /// <para>y��%y ��������Ԫ����ݡ������������Ԫ�����С�� 10������ʾ������ǰ�������ݡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%y����</para>  
        /// <para>yy ��������Ԫ����ݡ������������Ԫ�����С�� 10������ʾ����ǰ�������ݡ�</para>
        /// <para>yyyy ������Ԫ����λ������ݡ�</para>
        /// <para>d��%d ���е�ĳһ�졣һλ��������û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%d����</para>  
        /// <para>dd ���е�ĳһ�졣һλ����������һ��ǰ���㡣</para>  
        /// <para>ddd ����ĳ�����д���ơ�</para>  
        /// <para>dddd ����ĳ�����������</para>  
        /// <para>M��%M �·����֡�һλ�����·�û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%M����</para>  
        /// <para>MM �·����֡�һλ�����·���һ��ǰ���㡣</para>  
        /// <para>MMM �·ݵ���д���ơ�</para>  
        /// <para>MMMM �·ݵ��������ơ�</para>  
        /// <para>h��%h 12 Сʱ�Ƶ�Сʱ��һλ����Сʱ��û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%h����</para>
        /// <para>hh 12 Сʱ�Ƶ�Сʱ��һλ����Сʱ����ǰ���㡣 </para>
        /// <para>H��%H 24 Сʱ�Ƶ�Сʱ��һλ����Сʱ��û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%H����</para>
        /// <para>HH 24 Сʱ�Ƶ�Сʱ��һλ����Сʱ����ǰ���㡣</para>
        /// <para>m��%m ���ӡ�һλ���ķ�����û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%m����</para>
        /// <para>mm ���ӡ�һλ���ķ�������һ��ǰ���㡣</para>
        /// <para>s��%s �롣һλ��������û��ǰ���㡣����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%s����</para>
        /// <para>ss �롣һλ����������һ��ǰ���㡣</para>
        /// <para>f��%f ���С������Ϊһλ���������ֱ��ضϡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%f����</para>
        /// <para>ff ���С������Ϊ��λ���������ֱ��ضϡ�</para>
        /// <para>fff ���С������Ϊ��λ���������ֱ��ضϡ�</para>
        /// <para>F��%F ʾ���С�����ֵ������Ч���֡����������Ϊ�㣬����ʾ�κ����ݡ�����ø�ʽģʽû����������ʽģʽ��ϣ���ָ����%F����</para>
        /// <para>FF ��ʾ���С�����ֵ����������Ч���֡����ǣ�����ʾβ����㣨���������֣���</para>
        /// <para>FFF ��ʾ���С�����ֵ����������Ч���֡����ǣ�����ʾβ����㣨���������֣���</para>  
        /// </summary>
        /// <param name="dts">��Ҫ��ʽ���������ַ���</param>
        /// <param name="format">��ʽ�ַ���</param>
        /// <returns>�����Ѹ�ʽ�������ַ�����ʾ</returns>
        public static string GetDate(string dts, string format)
        {
            return Convert.ToDateTime(dts).ToString(format);
        }

        /// <summary>ʹ���滻�ؼ��ֶԵ�ǰʱ�����鲢��ʱ���ʽ��Ϊ�ȳ��ַ���(���磺2008-1-1 ��ʽ����2008-01-01)��
        /// <para>��ʽ��Ϊ�ȳ��ַ������滻�ؼ��֣�</para> 
        /// <para>{$Year} ��</para>  
        /// <para>{$Month} ��</para>  
        /// <para>{$Day} ��</para>  
        /// <para>{$Hour} ʱ</para>  
        /// <para>{$Minute} ��</para>  
        /// <para>{$Second} ��</para>  
        /// <para>{$Millisecond} ����</para>  
        /// <para>{$Random} 10000000��100000000֮���漴��</para> 
        /// <para>{$Addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$Addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// <para>ֱ���滻�ؼ��֣�</para> 
        /// <para>{$year} ��</para>  
        /// <para>{$month} ��</para>  
        /// <para>{$day} ��</para>  
        /// <para>{$hour} ʱ</para>  
        /// <para>{$minute} ��</para>  
        /// <para>{$second} ��</para>  
        /// <para>{$millisecond} ����</para>  
        /// <para>{$random} 10000000��100000000֮���漴��</para> 
        /// <para>{$addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// </summary>
        /// <param name="strInput">�����滻�ַ���</param>
        /// <returns>������������ַ���</returns>
        public static string ReFDateTime(string strInput)
        {
            return ReFDateTime(strInput, DateTime.Now);
        }

        /// <summary>ʹ���滻�ؼ��ֶԵ�ǰʱ�����鲢��ʱ���ʽ��Ϊ�ȳ��ַ���(���磺2008-1-1 ��ʽ����2008-01-01)��
        /// <para>��ʽ��Ϊ�ȳ��ַ������滻�ؼ��֣�</para> 
        /// <para>{$Year} ��</para>  
        /// <para>{$Month} ��</para>  
        /// <para>{$Day} ��</para>  
        /// <para>{$Hour} ʱ</para>  
        /// <para>{$Minute} ��</para>  
        /// <para>{$Second} ��</para>  
        /// <para>{$Millisecond} ����</para>  
        /// <para>{$Random} 10000000��100000000֮���漴��</para> 
        /// <para>{$Addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$Addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// <para>ֱ���滻�ؼ��֣�</para> 
        /// <para>{$year} ��</para>  
        /// <para>{$month} ��</para>  
        /// <para>{$day} ��</para>  
        /// <para>{$hour} ʱ</para>  
        /// <para>{$minute} ��</para>  
        /// <para>{$second} ��</para>  
        /// <para>{$millisecond} ����</para>  
        /// <para>{$random} 10000000��100000000֮���漴��</para> 
        /// <para>{$addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// </summary>
        /// <param name="strInput">�����滻�ַ���</param>
        /// <param name="sdate">һ���ַ���ʱ��</param>
        /// <returns>������������ַ���</returns>
        public static string ReFDateTime(string strInput, string sdate)
        {
            if (Often.IsDate(sdate))
            {
                return ReFDateTime(strInput, Convert.ToDateTime(sdate));
            }
            return "";
        }

        /// <summary>ʹ���滻�ؼ��ֶ�ʱ�����鲢��ʱ���ʽ��Ϊ�ȳ��ַ���(���磺2008-1-1 ��ʽ����2008-01-01)��
        /// <para>��ʽ��Ϊ�ȳ��ַ������滻�ؼ��֣�</para> 
        /// <para>{$Year} ��</para>  
        /// <para>{$Month} ��</para>  
        /// <para>{$Day} ��</para>  
        /// <para>{$Hour} ʱ</para>  
        /// <para>{$Minute} ��</para>  
        /// <para>{$Second} ��</para>  
        /// <para>{$Millisecond} ����</para>  
        /// <para>{$Random} 10000000��100000000֮���漴��</para> 
        /// <para>{$Addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$Addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// <para>ֱ���滻�ؼ��֣�</para> 
        /// <para>{$year} ��</para>  
        /// <para>{$month} ��</para>  
        /// <para>{$day} ��</para>  
        /// <para>{$hour} ʱ</para>  
        /// <para>{$minute} ��</para>  
        /// <para>{$second} ��</para>  
        /// <para>{$millisecond} ����</para>  
        /// <para>{$random} 10000000��100000000֮���漴��</para> 
        /// <para>{$addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// </summary>
        /// <param name="strInput">�����滻�ַ���</param>
        /// <param name="date">ʱ��</param>
        /// <returns>������������ַ���</returns>
        public static string ReFDateTime(string strInput, DateTime date)
        {
            strInput = strInput.Replace("{$Year}", date.Year.ToString());
            strInput = strInput.Replace("{$Month}", Often.LCharDup(date.Month.ToString(), '0', 2));
            strInput = strInput.Replace("{$Day}", Often.LCharDup(date.Day.ToString(), '0', 2));
            strInput = strInput.Replace("{$Hour}", Often.LCharDup(date.Hour.ToString(), '0', 2));
            strInput = strInput.Replace("{$Minute}", Often.LCharDup(date.Minute.ToString(), '0', 2));
            strInput = strInput.Replace("{$Second}", Often.LCharDup(date.Second.ToString(), '0', 2));
            strInput = strInput.Replace("{$Millisecond}", Often.LCharDup(date.Millisecond.ToString(), '0', 3));
            strInput = strInput.Replace("{$year}", date.Year.ToString());
            strInput = strInput.Replace("{$month}", date.Month.ToString());
            strInput = strInput.Replace("{$day}", date.Day.ToString());
            strInput = strInput.Replace("{$hour}", date.Hour.ToString());
            strInput = strInput.Replace("{$minute}", date.Minute.ToString());
            strInput = strInput.Replace("{$second}", date.Second.ToString());
            strInput = strInput.Replace("{$millisecond}", date.Millisecond.ToString());
            Random random = new Random(Often.Seed);
            strInput = strInput.Replace("{$Random}", random.Next(10000000, 100000000).ToString());
            strInput = strInput.Replace("{$random}", random.Next(10000000, 100000000).ToString());
            if (strInput.IndexOf("{$Addup}") > -1)
            {
                strInput = strInput.Replace("{$Addup}", Often.LCharDup(Often.AddupNum.ToString(), '0', 8));
            }
            if (strInput.IndexOf("{$addup}") > -1)
            {
                strInput = strInput.Replace("{$addup}", Often.AddupNum.ToString());
            }
            if (strInput.IndexOf("{$Addlongup}") > -1)
            {
                strInput = strInput.Replace("{$Addlongup}", Often.LCharDup(Often.AddupLongNum.ToString(), '0', 18));
            }
            if (strInput.IndexOf("{$addlongup}") > -1)
            {
                strInput = strInput.Replace("{$addlongup}", Often.AddupLongNum.ToString());
            }
            return strInput;
        }

        /// <summary>ʹ���滻�ؼ��ֶ�ʱ�����顣
        /// <para>�滻�ؼ��֣�</para>
        /// <para>{$Year} ��</para>
        /// <para>{$Month} ��</para>
        /// <para>{$Day} ��</para>
        /// <para>{$Hour} ʱ</para>  
        /// <para>{$Minute} ��</para> 
        /// <para>{$Second} ��</para>  
        /// <para>{$Millisecond} ����</para>  
        /// <para>{$Random} 10000000��100000000֮���漴��</para>
        /// <para>{$Addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$Addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// </summary>
        /// <param name="strInput">�����滻�ַ���</param>
        /// <returns>������������ַ���</returns>
        public static string ReDateTime(string strInput)
        {
            return ReDateTime(strInput, DateTime.Now);
        }

        /// <summary>ʹ���滻�ؼ��ֶ�ʱ�����顣
        /// <para>�滻�ؼ��֣�</para>
        /// <para>{$Year} ��</para>
        /// <para>{$Month} ��</para>
        /// <para>{$Day} ��</para>
        /// <para>{$Hour} ʱ</para>  
        /// <para>{$Minute} ��</para> 
        /// <para>{$Second} ��</para>  
        /// <para>{$Millisecond} ����</para>  
        /// <para>{$Random} 10000000��100000000֮���漴��</para>
        /// <para>{$Addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$Addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// </summary>
        /// <param name="strInput">�����滻�ַ���</param>
        /// <param name="sdate">һ���ַ���ʱ��</param>
        /// <returns>������������ַ���</returns>
        public static string ReDateTime(string strInput, string sdate)
        {
            if (Often.IsDate(sdate))
            {
                return ReDateTime(strInput, Convert.ToDateTime(sdate));
            }
            return "";
        }

        /// <summary>ʹ���滻�ؼ��ֶ�ʱ�����顣
        /// <para>�滻�ؼ��֣�</para>
        /// <para>{$Year} ��</para>
        /// <para>{$Month} ��</para>
        /// <para>{$Day} ��</para>
        /// <para>{$Hour} ʱ</para>  
        /// <para>{$Minute} ��</para> 
        /// <para>{$Second} ��</para>  
        /// <para>{$Millisecond} ����</para>  
        /// <para>{$Random} 10000000��100000000֮���漴��</para>
        /// <para>{$Addup} 1��99999999֮���ۼ���</para> 
        /// <para>{$Addlongup} 1��999999999999999999֮���ۼ���</para> 
        /// </summary>
        /// <param name="strInput">�����滻�ַ���</param>
        /// <param name="date">ʱ��</param>
        /// <returns>������������ַ���</returns>
        public static string ReDateTime(string strInput, DateTime date)
        {
            strInput = strInput.Replace("{$Year}", date.Year.ToString());
            strInput = strInput.Replace("{$Month}", date.Month.ToString());
            strInput = strInput.Replace("{$Day}", date.Day.ToString());
            strInput = strInput.Replace("{$Hour}", date.Hour.ToString());
            strInput = strInput.Replace("{$Minute}", date.Minute.ToString());
            strInput = strInput.Replace("{$Second}", date.Second.ToString());
            strInput = strInput.Replace("{$Millisecond}", date.Millisecond.ToString());
            Random random = new Random(Often.Seed);
            strInput = strInput.Replace("{$Random}", random.Next(10000000, 100000000).ToString());
            if (strInput.IndexOf("{$Addup}") > -1)
            {
                strInput = strInput.Replace("{$Addup}", Often.AddupNum.ToString());
            }
            if (strInput.IndexOf("{$Addlongup}") > -1)
            {
                strInput = strInput.Replace("{$Addlongup}", Often.AddupLongNum.ToString());
            }
            return strInput;
        }

        /// <summary>���ؿ�ʼ�����ʱ��֮��ļ��������</summary>
        /// <param name="startDate">��ʼʱ��</param>
        /// <param name="endDate">����ʱ��</param>
        /// <returns>���ؿ�ʼ�����ʱ��֮��ļ��������</returns>
        public static int GetTimeMinutes(string startDate, string endDate)
        {
            if (Often.IsDate(startDate) && Often.IsDate(endDate))
            {
                return GetTimeMinutes(Convert.ToDateTime(startDate), Convert.ToDateTime(endDate));
            }
            return 0;
        }

        /// <summary>���ؿ�ʼ�����ʱ��֮��ļ��������</summary>
        /// <param name="startDate">��ʼʱ��</param>
        /// <param name="endDate">����ʱ��</param>
        /// <returns>���ؿ�ʼ�����ʱ��֮��ļ��������</returns>
        public static int GetTimeMinutes(DateTime startDate, DateTime endDate)
        {
            TimeSpan ts1 = new TimeSpan(endDate.Ticks);
            TimeSpan ts2 = new TimeSpan(startDate.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            double dateDiff = ts.TotalMinutes;
            return Convert.ToInt32(dateDiff);
        }

        /// <summary>������������֮���ʱ������y����ݼ����M���·ݼ����d�����������h��Сʱ�����m�����Ӽ����s�����Ӽ����ms��΢������</summary>
        /// <param name="startDate">��ʼʱ��</param>
        /// <param name="endDate">����ʱ��</param>
        /// <param name="Interval">�����־��y����ݼ����M���·ݼ����d�����������h��Сʱ�����m�����Ӽ����s�����Ӽ����ms��΢������</param>
        /// <returns>������������֮���ʱ������y����ݼ����M���·ݼ����d�����������h��Сʱ�����m�����Ӽ����s�����Ӽ����ms��΢������</returns>
        public static int DateDiff(string startDate, string endDate, string Interval)
        {
            if (Often.IsDate(startDate) && Often.IsDate(endDate))
            {
                return DateDiff(Convert.ToDateTime(startDate), Convert.ToDateTime(endDate), Interval);
            }
            return 0;
        }

        /// <summary>������������֮���ʱ������y����ݼ����M���·ݼ����d�����������h��Сʱ�����m�����Ӽ����s�����Ӽ����ms��΢������</summary>
        /// <param name="startDate">��ʼʱ��</param>
        /// <param name="endDate">����ʱ��</param>
        /// <param name="Interval">�����־��y����ݼ����M���·ݼ����d�����������h��Сʱ�����m�����Ӽ����s�����Ӽ����ms��΢������</param>
        /// <returns>������������֮���ʱ������y����ݼ����M���·ݼ����d�����������h��Сʱ�����m�����Ӽ����s�����Ӽ����ms��΢������</returns>
        public static int DateDiff(System.DateTime startDate, System.DateTime endDate, string Interval)
        {
            double dblYearLen = 365;//��ĳ��ȣ�365��   
            double dblMonthLen = (365 / 12);//ÿ����ƽ��������   
            System.TimeSpan objT;
            objT = endDate.Subtract(startDate);
            switch (Interval)
            {
                case "y"://�������ڵ���ݼ��   
                    return System.Convert.ToInt32(objT.Days / dblYearLen);
                case "M"://�������ڵ��·ݼ��   
                    return System.Convert.ToInt32(objT.Days / dblMonthLen);
                case "d"://�������ڵ��������   
                    return objT.Days;
                case "h"://�������ڵ�Сʱ���   
                    return objT.Hours;
                case "m"://�������ڵķ��Ӽ��   
                    return objT.Minutes;
                case "s"://�������ڵ����Ӽ��   
                    return objT.Seconds;
                case "ms"://����ʱ���΢����   
                    return objT.Milliseconds;
                default:
                    break;
            }
            return 0;
        }

        /// <summary>����ͳ��ģʽ����ͳ������</summary>
        /// <param name="cmode">ͳ��ģʽ,0:��;1:��;2:��;3:��;4:����;5:��;6:�Զ���;</param>
        /// <param name="addmode">����ģʽ,0:ָ������;1:ָ�����ڵ���һ����(������);2:ָ�����ڵ���һ����;3:ָ�����ڵ�ͬ����;</param>
        /// <param name="sdate">��Ҫ���㲢���صĿ�ʼ����</param>
        /// <param name="edate">��Ҫ���㲢���صĽ�������</param>
        public static void LoadCountDate(string cmode, string addmode, ref DateTime sdate, ref DateTime edate)
        {
            if (edate < sdate)
            {
                edate = sdate;
            }
            if (cmode == "1")
            {
                edate = sdate;
                if (addmode == "1")
                {
                    sdate = GetWeekUpMonday(sdate);
                    edate = GetWeekUpSunday(edate);
                }
                else if (addmode == "2")
                {
                    sdate = GetWeekNextMonday(sdate);
                    edate = GetWeekNextSunday(edate);
                }
                else if (addmode == "3")
                {
                    sdate = GetWeekMondayOn(sdate);
                    edate = GetWeekSundayOn(edate);
                }
                else
                {
                    sdate = GetWeekMonday(sdate);
                    edate = GetWeekSunday(edate);
                }
            }
            else if (cmode == "2")
            {
                edate = sdate;
                if (addmode == "1")
                {
                    sdate = GetMonthUpStart(sdate);
                    edate = GetMonthUpEnd(edate);
                }
                else if (addmode == "2")
                {
                    sdate = GetMonthNextStart(sdate);
                    edate = GetMonthNextEnd(edate);
                }
                else if (addmode == "3")
                {
                    sdate = GetMonthStartOn(sdate);
                    edate = GetMonthEndOn(edate);
                }
                else
                {
                    sdate = GetMonthStart(sdate);
                    edate = GetMonthEnd(edate);
                }
            }
            else if (cmode == "3")
            {
                edate = sdate;
                if (addmode == "1")
                {
                    sdate = GetSeasonUpStart(sdate);
                    edate = GetSeasonUpEnd(edate);
                }
                else if (addmode == "2")
                {
                    sdate = GetSeasonNextStart(sdate);
                    edate = GetSeasonNextEnd(edate);
                }
                else if (addmode == "3")
                {
                    sdate = GetSeasonStartOn(sdate);
                    edate = GetSeasonEndOn(edate);
                }
                else
                {
                    sdate = GetSeasonStart(sdate);
                    edate = GetSeasonEnd(edate);
                }
            }
            else if (cmode == "4")
            {
                edate = sdate;
                if (addmode == "1")
                {
                    sdate = GetHalfyearUpStart(sdate);
                    edate = GetHalfyearUpEnd(edate);
                }
                else if (addmode == "2")
                {
                    sdate = GetHalfyearNextStart(sdate);
                    edate = GetHalfyearNextEnd(edate);
                }
                else if (addmode == "3")
                {
                    sdate = GetHalfyearStartOn(sdate);
                    edate = GetHalfyearEndOn(edate);
                }
                else
                {
                    sdate = GetHalfyearStart(sdate);
                    edate = GetHalfyearEnd(edate);
                }
            }
            else if (cmode == "5")
            {
                edate = sdate;
                if (addmode == "1")
                {
                    sdate = GetYearUpStart(sdate);
                    edate = GetYearUpEnd(edate);
                }
                else if (addmode == "2")
                {
                    sdate = GetYearNextStart(sdate);
                    edate = GetYearNextEnd(edate);
                }
                else if (addmode == "3")
                {
                    sdate = GetYearStartOn(sdate);
                    edate = GetYearEndOn(edate);
                }
                else
                {
                    sdate = GetYearStart(sdate);
                    edate = GetYearEnd(edate);
                }
            }
            else if (cmode == "6")
            {
                int daynum = Math.Abs(DateOften.DateDiff(sdate, edate, "d")) + 1;
                if (addmode == "1")
                {
                    sdate = sdate.AddDays(-daynum);
                    edate = edate.AddDays(-daynum);
                }
                else if (addmode == "2")
                {
                    sdate = sdate.AddDays(daynum);
                    edate = edate.AddDays(daynum);
                }
                else if (addmode == "3")
                {
                    sdate = sdate.AddYears(-1);
                    edate = edate.AddYears(-1);
                }
            }
            else
            {
                if (addmode == "1")
                {
                    sdate = sdate.AddDays(-1);
                }
                else if (addmode == "2")
                {
                    sdate = sdate.AddDays(1);
                }
                else if (addmode == "3")
                {
                    sdate = sdate.AddYears(-1);
                }
                edate = sdate;
            }
            LoadSEDate(ref sdate, ref edate);
        }

        /// <summary>����ͳ��ģʽ����ͳ������</summary>
        /// <param name="cmode">ͳ��ģʽ,0:��;1:��;2:��;3:��;4:����;5:��;6:�Զ���;</param>
        /// <param name="addmode">����ģʽ,0:��ǰ����;1:��һ����(������);2:��һ����;3:ָ�����ڵ�ͬ����;</param>
        /// <param name="sdate">��Ҫ���㲢���صĿ�ʼ����</param>
        /// <param name="edate">��Ҫ���㲢���صĽ�������</param>
        public static void LoadCountDate(string cmode, string addmode, ref string sdate, ref string edate)
        {
            DateTime dqrq = DateTime.Now;
            if (!Often.IsDate(sdate))
            {
                sdate = dqrq.ToString();
            }
            if (!Often.IsDate(edate))
            {
                edate = sdate;
            }
            DateTime srq = Convert.ToDateTime(sdate);
            DateTime erq = Convert.ToDateTime(edate);
            LoadCountDate(cmode, addmode, ref srq, ref erq);
            sdate = srq.ToString();
            edate = erq.ToString();
        }

        /// <summary>��ʽ��ͳ������</summary>
        /// <param name="cmode">ͳ��ģʽ,0:��;1:��;2:��;3:��;4:����;5:��;6:�Զ���;</param>
        /// <param name="addmode">����ģʽ,0:��ǰ����;1:��һ����(������);2:��һ����;3:ָ�����ڵ�ͬ����;</param>
        /// <param name="sdates">��Ҫ���㲢���صĿ�ʼ����</param>
        /// <param name="edates">��Ҫ���㲢���صĽ�������</param>
        public static void FormatCountDate(string cmode, string addmode, ref string sdates, ref string edates)
        {
            DateTime dqrq = DateTime.Now;
            DateTime sdate = dqrq;
            DateTime edate = dqrq;
            if (Often.IsDate(sdates))
            {
                sdate = Convert.ToDateTime(sdates);
            }
            if (Often.IsDate(edates))
            {
                edate = Convert.ToDateTime(edates);
            }
            FormatCountDate(cmode, addmode, ref sdate, ref edate);
            sdates = sdate.ToString();
            edates = edate.ToString();
        }

        /// <summary>��ʽ��ͳ������</summary>
        /// <param name="cmode">ͳ��ģʽ,0:��;1:��;2:��;3:��;4:����;5:��;6:�Զ���;</param>
        /// <param name="addmode">����ģʽ,0:��ǰ����;1:��һ����(������);2:��һ����;3:ָ�����ڵ�ͬ����;</param>
        /// <param name="sdate">��Ҫ���㲢���صĿ�ʼ����</param>
        /// <param name="edate">��Ҫ���㲢���صĽ�������</param>
        public static void FormatCountDate(string cmode, string addmode, ref DateTime sdate, ref DateTime edate)
        {
            int cmodeint = 0;
            if (Often.IsInt32(cmode))
            {
                cmodeint = Convert.ToInt32(cmode);
            }
            int addmodeint = 0;
            if (Often.IsInt32(addmode))
            {
                addmodeint = Convert.ToInt32(addmode);
            }
            if (cmodeint != 6 && addmodeint == 0)
            {
                DateTime dqrq = DateTime.Now;
                sdate = dqrq;
                edate = dqrq;
            }
        }

        /// <summary>���ؿ�ʼ��������ʱ���뷵�ؽ�����������ʱ��</summary>
        /// <param name="sdate">���ؿ�ʼ��������ʱ��</param>
        /// <param name="edate">���ؽ�����������ʱ��</param>
        public static void LoadSEDate(ref DateTime sdate, ref DateTime edate)
        {
            if (edate < sdate)
            {
                edate = sdate;
            }
            sdate = Convert.ToDateTime(DateOften.ReFDateTime("{$Year}-{$Month}-{$Day} 0:0:0", sdate));
            edate = Convert.ToDateTime(DateOften.ReFDateTime("{$Year}-{$Month}-{$Day} 23:59:59", edate));
        }

        /// <summary>���ؿ�ʼ��������ʱ���뷵�ؽ�����������ʱ��</summary>
        /// <param name="sdates">���ؿ�ʼ��������ʱ��</param>
        /// <param name="edates">���ؽ�����������ʱ��</param>
        public static void LoadSEDate(ref string sdates, ref string edates)
        {
            DateTime dqrq = DateTime.Now;
            DateTime sdate = dqrq;
            DateTime edate = dqrq;
            if (Often.IsDate(sdates))
            {
                sdate = Convert.ToDateTime(sdates);
            }
            if (Often.IsDate(edates))
            {
                edate = Convert.ToDateTime(edates);
            }
            LoadSEDate(ref sdate, ref edate);
            sdates = sdate.ToString();
            edates = edate.ToString();
        }

        /// <summary>����ָ�����ڵ���һ����һ</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ����һ</returns>
        public static DateTime GetWeekUpMonday(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetWeekUpMonday(DateTime.Now);
            }
            return GetWeekUpMonday(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ����һ</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ����һ</returns>
        public static DateTime GetWeekUpMonday(DateTime rq)
        {
            return GetWeekMonday(rq).AddDays(-7);
        }

        /// <summary>����ָ�����ڵ���һ������</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ������</returns>
        public static DateTime GetWeekUpSunday(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetWeekUpSunday(DateTime.Now);
            }
            return GetWeekUpSunday(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ������</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ������</returns>
        public static DateTime GetWeekUpSunday(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", GetWeekUpMonday(rq).AddDays(6)));
        }

        /// <summary>����ָ�����ڵ���һ����һ</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ����һ</returns>
        public static DateTime GetWeekNextMonday(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetWeekNextMonday(DateTime.Now);
            }
            return GetWeekNextMonday(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ����һ</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ����һ</returns>
        public static DateTime GetWeekNextMonday(DateTime rq)
        {
            return GetWeekSunday(rq).AddDays(1);
        }

        /// <summary>����ָ�����ڵ���һ������</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ������</returns>
        public static DateTime GetWeekNextSunday(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetWeekNextSunday(DateTime.Now);
            }
            return GetWeekNextSunday(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ������</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ������</returns>
        public static DateTime GetWeekNextSunday(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", GetWeekNextMonday(rq).AddDays(6)));
        }

        /// <summary>����ָ�����ڵı�����һ</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����һ</returns>
        public static DateTime GetWeekMonday(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetWeekMonday(DateTime.Now);
            }
            return GetWeekMonday(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı�����һ</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����һ</returns>
        public static DateTime GetWeekMonday(DateTime rq)
        {
            DateTime srq = rq.AddDays(1 - DayToNumWeek(rq));
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 0:0:0", srq));
        }

        /// <summary>����ָ�����ڵı�������</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�������</returns>
        public static DateTime GetWeekSunday(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetWeekSunday(DateTime.Now);
            }
            return GetWeekSunday(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı�������</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�������</returns>
        public static DateTime GetWeekSunday(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", GetWeekMonday(rq).AddDays(6)));
        }

        /// <summary>����ָ�����ڵ���һ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�����һ��</returns>
        public static DateTime GetMonthUpEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetMonthUpEnd(DateTime.Now);
            }
            return GetMonthUpEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�����һ��</returns>
        public static DateTime GetMonthUpEnd(DateTime rq)
        {
            DateTime srq = GetMonthUpStart(rq).AddMonths(1).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵ���һ�µ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�µ�һ��</returns>
        public static DateTime GetMonthUpStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetMonthUpStart(DateTime.Now);
            }
            return GetMonthUpStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ�µ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�µ�һ��</returns>
        public static DateTime GetMonthUpStart(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-1 0:0:0", rq.AddMonths(-1)));
        }

        /// <summary>����ָ�����ڵ���һ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�����һ��</returns>
        public static DateTime GetMonthNextEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetMonthNextEnd(DateTime.Now);
            }
            return GetMonthNextEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�����һ��</returns>
        public static DateTime GetMonthNextEnd(DateTime rq)
        {
            DateTime srq = GetMonthNextStart(rq).AddMonths(1).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵ���һ�µ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�µ�һ��</returns>
        public static DateTime GetMonthNextStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetMonthNextStart(DateTime.Now);
            }
            return GetMonthNextStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ�µ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�µ�һ��</returns>
        public static DateTime GetMonthNextStart(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-1 0:0:0", rq.AddMonths(1)));
        }

        /// <summary>����ָ�����ڵı������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı������һ��</returns>
        public static DateTime GetMonthEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetMonthEnd(DateTime.Now);
            }
            return GetMonthEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı������һ��</returns>
        public static DateTime GetMonthEnd(DateTime rq)
        {
            DateTime srq = GetMonthStart(rq).AddMonths(1).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵı��µ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı��µ�һ��</returns>
        public static DateTime GetMonthStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetMonthStart(DateTime.Now);
            }
            return GetMonthStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı��µ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı��µ�һ��</returns>
        public static DateTime GetMonthStart(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-1 0:0:0", rq));
        }

        /// <summary>����ָ�����ڵ���һ�������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�������һ��</returns>
        public static DateTime GetSeasonUpEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetSeasonUpEnd(DateTime.Now);
            }
            return GetSeasonUpEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ�������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�������һ��</returns>
        public static DateTime GetSeasonUpEnd(DateTime rq)
        {
            DateTime srq = GetSeasonStart(rq).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵ���һ���ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ���ȵ�һ��</returns>
        public static DateTime GetSeasonUpStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetSeasonUpStart(DateTime.Now);
            }
            return GetSeasonUpStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ���ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ���ȵ�һ��</returns>
        public static DateTime GetSeasonUpStart(DateTime rq)
        {
            return GetSeasonStart(GetSeasonUpEnd(rq));
        }

        /// <summary>����ָ�����ڵ���һ�������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�������һ��</returns>
        public static DateTime GetSeasonNextEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetSeasonNextEnd(DateTime.Now);
            }
            return GetSeasonNextEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ�������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�������һ��</returns>
        public static DateTime GetSeasonNextEnd(DateTime rq)
        {
            return GetSeasonEnd(GetSeasonNextStart(rq));
        }

        /// <summary>����ָ�����ڵ���һ���ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ���ȵ�һ��</returns>
        public static DateTime GetSeasonNextStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetSeasonNextStart(DateTime.Now);
            }
            return GetSeasonNextStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ���ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ���ȵ�һ��</returns>
        public static DateTime GetSeasonNextStart(DateTime rq)
        {
            DateTime srq = GetSeasonEnd(rq).AddDays(1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-1 0:0:0", srq));
        }

        /// <summary>����ָ�����ڵı��������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı��������һ��</returns>
        public static DateTime GetSeasonEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetSeasonEnd(DateTime.Now);
            }
            return GetSeasonEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı��������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı��������һ��</returns>
        public static DateTime GetSeasonEnd(DateTime rq)
        {
            DateTime srq = GetSeasonStart(rq).AddMonths(3).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵı����ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı����ȵ�һ��</returns>
        public static DateTime GetSeasonStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetSeasonStart(DateTime.Now);
            }
            return GetSeasonStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı����ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı����ȵ�һ��</returns>
        public static DateTime GetSeasonStart(DateTime rq)
        {
            DateTime srq = rq.AddMonths(0 - (rq.Month - 1) % 3).AddDays(1 - rq.Day);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-1 0:0:0", srq));
        }

        /// <summary>����ָ�����ڵ���һ��������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ��ϰ�������һ��</returns>
        public static DateTime GetHalfyearUpEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetHalfyearUpEnd(DateTime.Now);
            }
            return GetHalfyearUpEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ��������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ��������һ��</returns>
        public static DateTime GetHalfyearUpEnd(DateTime rq)
        {
            DateTime srq = GetHalfyearStart(rq).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵ���һ����ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ����ȵ�һ��</returns>
        public static DateTime GetHalfyearUpStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetHalfyearUpStart(DateTime.Now);
            }
            return GetHalfyearUpStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ����ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ����ȵ�һ��</returns>
        public static DateTime GetHalfyearUpStart(DateTime rq)
        {
            return GetHalfyearStart(GetHalfyearUpEnd(rq));
        }

        /// <summary>����ָ�����ڵ���һ��������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ��������һ��</returns>
        public static DateTime GetHalfyearNextEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetHalfyearNextEnd(DateTime.Now);
            }
            return GetHalfyearNextEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ��������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ��������һ��</returns>
        public static DateTime GetHalfyearNextEnd(DateTime rq)
        {
            return GetHalfyearEnd(GetHalfyearNextStart(rq));
        }

        /// <summary>����ָ�����ڵ���һ����ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ����ȵ�һ��</returns>
        public static DateTime GetHalfyearNextStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetHalfyearNextStart(DateTime.Now);
            }
            return GetHalfyearNextStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ����ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ����ȵ�һ��</returns>
        public static DateTime GetHalfyearNextStart(DateTime rq)
        {
            DateTime srq = GetHalfyearEnd(rq).AddDays(1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-1 0:0:0", srq));
        }

        /// <summary>����ָ�����ڵı��������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı��������һ��</returns>
        public static DateTime GetHalfyearEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetHalfyearEnd(DateTime.Now);
            }
            return GetHalfyearEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı��������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı��������һ��</returns>
        public static DateTime GetHalfyearEnd(DateTime rq)
        {
            int yf = rq.Month;
            if (yf > 6)
            {
                return GetMonthEnd(Convert.ToDateTime(DateOften.ReDateTime("{$Year}-12-1 0:0:0", rq)));
            }
            else
            {
                return GetMonthEnd(Convert.ToDateTime(DateOften.ReDateTime("{$Year}-6-1 0:0:0", rq)));
            }
        }

        /// <summary>����ָ�����ڵı������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı������һ��</returns>
        public static DateTime GetHalfyearStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetHalfyearStart(DateTime.Now);
            }
            return GetHalfyearStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı������һ��</returns>
        public static DateTime GetHalfyearStart(DateTime rq)
        {
            int yf = rq.Month;
            if (yf > 6)
            {
                return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-7-1 0:0:0", rq));
            }
            else
            {
                return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-1-1 0:0:0", rq));
            }
        }

        /// <summary>����ָ�����ڵ���һ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�����һ��</returns>
        public static DateTime GetYearUpEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetYearUpEnd(DateTime.Now);
            }
            return GetYearUpEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�����һ��</returns>
        public static DateTime GetYearUpEnd(DateTime rq)
        {
            DateTime srq = GetYearUpStart(rq).AddYears(1).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵ���һ���һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ���һ��</returns>
        public static DateTime GetYearUpStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetYearUpStart(DateTime.Now);
            }
            return GetYearUpStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ���һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ���һ��</returns>
        public static DateTime GetYearUpStart(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-1-1 0:0:0", rq.AddYears(-1)));
        }

        /// <summary>����ָ�����ڵ���һ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�����һ��</returns>
        public static DateTime GetYearNextEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetYearNextEnd(DateTime.Now);
            }
            return GetYearNextEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ�����һ��</returns>
        public static DateTime GetYearNextEnd(DateTime rq)
        {
            DateTime srq = GetYearNextStart(rq).AddYears(1).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵ���һ���һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ���һ��</returns>
        public static DateTime GetYearNextStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetYearNextStart(DateTime.Now);
            }
            return GetYearNextStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵ���һ���һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵ���һ���һ��</returns>
        public static DateTime GetYearNextStart(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-1-1 0:0:0", rq.AddYears(1)));
        }

        /// <summary>����ָ�����ڵı������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı������һ��</returns>
        public static DateTime GetYearEnd(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetYearEnd(DateTime.Now);
            }
            return GetYearEnd(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı������һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı������һ��</returns>
        public static DateTime GetYearEnd(DateTime rq)
        {
            DateTime srq = GetYearStart(rq).AddYears(1).AddDays(-1);
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-{$Day} 23:59:59", srq));
        }

        /// <summary>����ָ�����ڵı����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı����һ��</returns>
        public static DateTime GetYearStart(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetYearStart(DateTime.Now);
            }
            return GetYearStart(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı����һ��</returns>
        public static DateTime GetYearStart(DateTime rq)
        {
            return Convert.ToDateTime(DateOften.ReDateTime("{$Year}-1-1 0:0:0", rq));
        }

        /// <summary>����ָ�����ڵı���ͬ����һ</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ����һ</returns>
        public static DateTime GetWeekMondayOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetWeekMondayOn(DateTime.Now);
            }
            return GetWeekMondayOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı���ͬ����һ</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ����һ</returns>
        public static DateTime GetWeekMondayOn(DateTime rq)
        {
            DateTime trq = GetWeekMonday(rq.AddYears(-1));
            int dwnum = GetDayOfWeek(rq);
            int tdwnum = GetDayOfWeek(trq);
            int ynum = trq.Year;
            int nynum = ynum;
            while (dwnum != tdwnum && nynum == ynum)
            {
                DateTime crq = trq;
                if (dwnum > tdwnum)
                {
                    crq = GetWeekNextMonday(crq);
                    tdwnum++;
                }
                else
                {
                    crq = GetWeekUpMonday(crq);
                    tdwnum--;
                }
                nynum = crq.Year;
                if (nynum == ynum)
                {
                    trq = crq;
                }
            }
            return trq;
        }

        /// <summary>����ָ�����ڵı���ͬ������</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ������</returns>
        public static DateTime GetWeekSundayOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetWeekSundayOn(DateTime.Now);
            }
            return GetWeekSundayOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı���ͬ������</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ������</returns>
        public static DateTime GetWeekSundayOn(DateTime rq)
        {
            DateTime trq = GetWeekSunday(rq.AddYears(-1));
            int dwnum = GetDayOfWeek(rq);
            int tdwnum = GetDayOfWeek(trq);
            int ynum = trq.Year;
            int nynum = ynum;
            while (dwnum != tdwnum && nynum == ynum)
            {
                DateTime crq = trq;
                if (dwnum > tdwnum)
                {
                    crq = GetWeekNextSunday(crq);
                    tdwnum++;
                }
                else
                {
                    crq = GetWeekUpSunday(crq);
                    tdwnum--;
                }
                nynum = crq.Year;
                if (nynum == ynum)
                {
                    trq = crq;
                }
            }
            return trq;
        }

        /// <summary>����ָ�����ڵı���ͬ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ�����һ��</returns>
        public static DateTime GetMonthEndOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetMonthEndOn(DateTime.Now);
            }
            return GetMonthEndOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı���ͬ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ�����һ��</returns>
        public static DateTime GetMonthEndOn(DateTime rq)
        {
            return GetMonthEnd(rq.AddYears(-1));
        }

        /// <summary>����ָ�����ڵı���ͬ�ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ�ȵ�һ��</returns>
        public static DateTime GetMonthStartOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetMonthStartOn(DateTime.Now);
            }
            return GetMonthStartOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı���ͬ�ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ�ȵ�һ��</returns>
        public static DateTime GetMonthStartOn(DateTime rq)
        {
            return GetMonthStart(rq.AddYears(-1));
        }

        /// <summary>����ָ�����ڵı�����ͬ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����ͬ�����һ��</returns>
        public static DateTime GetSeasonEndOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetSeasonEndOn(DateTime.Now);
            }
            return GetSeasonEndOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı�����ͬ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����ͬ�����һ��</returns>
        public static DateTime GetSeasonEndOn(DateTime rq)
        {
            return GetSeasonEnd(rq.AddYears(-1));
        }

        /// <summary>����ָ�����ڵı�����ͬ�ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����ͬ�ȵ�һ��</returns>
        public static DateTime GetSeasonStartOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetSeasonStartOn(DateTime.Now);
            }
            return GetSeasonStartOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı�����ͬ�ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����ͬ�ȵ�һ��</returns>
        public static DateTime GetSeasonStartOn(DateTime rq)
        {
            return GetSeasonStart(rq.AddYears(-1));
        }

        /// <summary>����ָ�����ڵı�����ͬ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����ͬ�����һ��</returns>
        public static DateTime GetHalfyearEndOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetHalfyearEndOn(DateTime.Now);
            }
            return GetHalfyearEndOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı�����ͬ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����ͬ�����һ��</returns>
        public static DateTime GetHalfyearEndOn(DateTime rq)
        {
            return GetHalfyearEnd(rq.AddYears(-1));
        }

        /// <summary>����ָ�����ڵı�����ͬ�ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����ͬ�ȵ�һ��</returns>
        public static DateTime GetHalfyearStartOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetHalfyearStartOn(DateTime.Now);
            }
            return GetHalfyearStartOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı�����ͬ�ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı�����ͬ�ȵ�һ��</returns>
        public static DateTime GetHalfyearStartOn(DateTime rq)
        {
            return GetHalfyearStart(rq.AddYears(-1));
        }

        /// <summary>����ָ�����ڵı���ͬ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ�����һ��</returns>
        public static DateTime GetYearEndOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetYearEndOn(DateTime.Now);
            }
            return GetYearEndOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı���ͬ�����һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ�����һ��</returns>
        public static DateTime GetYearEndOn(DateTime rq)
        {
            return GetYearEnd(rq.AddYears(-1));
        }

        /// <summary>����ָ�����ڵı���ͬ�ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ�ȵ�һ��</returns>
        public static DateTime GetYearStartOn(string rq)
        {
            if (!Often.IsDate(rq))
            {
                return GetYearStartOn(DateTime.Now);
            }
            return GetYearStartOn(Convert.ToDateTime(rq));
        }

        /// <summary>����ָ�����ڵı���ͬ�ȵ�һ��</summary>
        /// <param name="rq">����</param>
        /// <returns>����ָ�����ڵı���ͬ�ȵ�һ��</returns>
        public static DateTime GetYearStartOn(DateTime rq)
        {
            return GetYearStart(rq.AddYears(-1));
        }

        /// <summary>����ָ�������Ǳ���ȵڼ���</summary>
        /// <param name="date">ָ������</param>
        /// <returns>����ָ�������Ǳ���ȵڼ���</returns>
        public static int GetDayOfWeek(string date)
        {
            if (!Often.IsDate(date))
            {
                return GetDayOfWeek(DateTime.Now);
            }
            return GetDayOfWeek(Convert.ToDateTime(date));
        }

        /// <summary>����ָ�������Ǳ���ȵڼ���</summary>
        /// <param name="date">ָ������</param>
        /// <returns>����ָ�������Ǳ���ȵڼ���</returns>
        public static int GetDayOfWeek(DateTime date)
        {
            return date.DayOfYear / 7 + 1;
        }

        /// <summary>����ָ�������Ǳ����еڼ���</summary>
        /// <param name="date">ָ������</param>
        /// <returns>����ָ�������Ǳ����еڼ���</returns>
        public static int WeekOfMonth(string date)
        {
            if (!Often.IsDate(date))
            {
                return WeekOfMonth(DateTime.Now);
            }
            return WeekOfMonth(Convert.ToDateTime(date));
        }

        /// <summary>����ָ�������Ǳ����еڼ���</summary>
        /// <param name="date">ָ������</param>
        /// <returns>����ָ�������Ǳ����еڼ���</returns>
        public static int WeekOfMonth(DateTime date)
        {
            DateTime FirstofMonth = Convert.ToDateTime(DateOften.ReDateTime("{$Year}-{$Month}-01", date));
            int i = (int)DayToNumWeek(FirstofMonth);
            return (date.Date.Day + i - 2) / 7 + 1;
        }

        /// <summary>����ָ�������Ǳ���ȵڼ�����</summary>
        /// <param name="date">ָ������</param>
        /// <returns>����ָ�������Ǳ���ȵڼ�����</returns>
        public static int GetSeasonNum(string date)
        {
            if (!Often.IsDate(date))
            {
                return GetSeasonNum(DateTime.Now);
            }
            return GetSeasonNum(Convert.ToDateTime(date));
        }

        /// <summary>����ָ�������Ǳ���ȵڼ�����</summary>
        /// <param name="date">ָ������</param>
        /// <returns>����ָ�������Ǳ���ȵڼ�����</returns>
        public static int GetSeasonNum(DateTime date)
        {
            int m = date.Month;
            if (m < 4)
            {
                return 1;
            }
            else if (m > 3 && m < 7)
            {
                return 2;
            }
            else if (m > 6 && m < 10)
            {
                return 3;
            }
            return 4;
        }

        /// <summary>����ָ�������Ǳ�������ϰ���������°���</summary>
        /// <param name="date">ָ������</param>
        /// <returns>����ָ�������Ǳ�������ϰ���������°���</returns>
        public static string GetSemiyearly(string date)
        {
            if (!Often.IsDate(date))
            {
                return GetSemiyearly(DateTime.Now);
            }
            return GetSemiyearly(Convert.ToDateTime(date));
        }

        /// <summary>����ָ�������Ǳ�������ϰ���������°���</summary>
        /// <param name="date">ָ������</param>
        /// <returns>����ָ�������Ǳ�������ϰ���������°���</returns>
        public static string GetSemiyearly(DateTime date)
        {
            int m = date.Month;
            if (m < 7)
            {
                return "�ϰ���";
            }
            else
            {
                return "�°���";
            }
        }

        /// <summary>����ͳ��ģʽ����ͳ�Ʊ�������</summary>
        /// <param name="cmode">ͳ��ģʽ,0:��;1:��;2:��;3:��;4:����;5:��;6:�Զ���;</param>
        /// <param name="sdate">��ʼ����</param>
        /// <param name="edate">��������</param>
        /// <returns>����ͳ��ģʽ����ͳ�Ʊ�������</returns>
        public static string GetCountTitle(string cmode, string sdate, string edate)
        {
            if (cmode == "1")
            {
                return DateOften.ReDateTime("{$Year}", sdate) + "���" + DateOften.GetDayOfWeek(sdate).ToString() + "��";
            }
            else if (cmode == "2")
            {
                return DateOften.ReDateTime("{$Year}��{$Month}��", sdate);
            }
            else if (cmode == "3")
            {
                return DateOften.ReDateTime("{$Year}", sdate) + "���" + DateOften.GetSeasonNum(sdate).ToString() + "��";
            }
            else if (cmode == "4")
            {
                return DateOften.ReDateTime("{$Year}", sdate) + "��" + DateOften.GetSemiyearly(sdate).ToString();
            }
            else if (cmode == "5")
            {
                return DateOften.ReDateTime("{$Year}��", sdate);
            }
            return DateOften.ReDateTime("{$Year}��{$Month}��{$Day}��", sdate) + "-" + DateOften.ReDateTime("{$Year}��{$Month}��{$Day}��", edate);
        }

        /// <summary>����ͳ��ģʽ����ͳ�Ʊ�������</summary>
        /// <param name="cmode">ͳ��ģʽ,0:��;1:��;2:��;3:��;4:����;5:��;6:�Զ���;</param>
        /// <param name="sdate">��ʼ����</param>
        /// <param name="edate">��������</param>
        /// <returns>����ͳ��ģʽ����ͳ�Ʊ�������</returns>
        public static string GetCountTitle(string cmode, DateTime sdate, DateTime edate)
        {
            if (cmode == "1")
            {
                return DateOften.ReDateTime("{$Year}", sdate) + "���" + DateOften.GetDayOfWeek(sdate).ToString() + "��";
            }
            else if (cmode == "2")
            {
                return DateOften.ReDateTime("{$Year}��{$Month}��", sdate);
            }
            else if (cmode == "3")
            {
                return DateOften.ReDateTime("{$Year}", sdate) + "���" + DateOften.GetSeasonNum(sdate).ToString() + "��";
            }
            else if (cmode == "4")
            {
                return DateOften.ReDateTime("{$Year}", sdate) + "��" + DateOften.GetSemiyearly(sdate).ToString();
            }
            else if (cmode == "5")
            {
                return DateOften.ReDateTime("{$Year}��", sdate);
            }
            return DateOften.ReDateTime("{$Year}��{$Month}��{$Day}��", sdate) + "-" + DateOften.ReDateTime("{$Year}��{$Month}��{$Day}��", edate);
        }

        /// <summary>����ͳ��ģʽ����ͳ�Ʊ���</summary>
        /// <param name="cmode">ͳ��ģʽ,0:��;1:��;2:��;3:��;4:����;5:��;6:�Զ���;</param>
        /// <param name="addmode">����ģʽ,0:��������;1:��������(������);2:��������;3:ͬ������;</param>
        /// <param name="sdate">��ʼ����</param>
        /// <returns>����ͳ��ģʽ����ͳ�Ʊ���</returns>
        public static string GetDateTitle(string cmode, string addmode, string sdate)
        {
            if (cmode == "1")
            {
                if (addmode == "0")
                {
                    return "����(��" + DateOften.GetDayOfWeek(sdate).ToString() + "��)";
                }
                else if (addmode == "1")
                {
                    return "����(��" + DateOften.GetDayOfWeek(sdate).ToString() + "��)";
                }
                else if (addmode == "2")
                {
                    return "����(��" + DateOften.GetDayOfWeek(sdate).ToString() + "��)";
                }
                else if (addmode == "3")
                {
                    return "ͬ��(��" + DateOften.GetDayOfWeek(sdate).ToString() + "��)";
                }
            }
            else if (cmode == "2")
            {
                DateTime rq = DateTime.Now;
                if (Often.IsDate(sdate))
                {
                    rq = Convert.ToDateTime(sdate);
                }
                int m = rq.Month;
                if (addmode == "0")
                {
                    return "����(" + m.ToString() + "��)";
                }
                else if (addmode == "1")
                {
                    return "����(" + m.ToString() + "��)";
                }
                else if (addmode == "2")
                {
                    return "����(" + m.ToString() + "��)";
                }
                else if (addmode == "3")
                {
                    return "ͬ��(" + m.ToString() + "��)";
                }
            }
            else if (cmode == "3")
            {
                if (addmode == "0")
                {
                    return "����(��" + DateOften.GetSeasonNum(sdate).ToString() + "��)";
                }
                else if (addmode == "1")
                {
                    return "�ϼ�(��" + DateOften.GetSeasonNum(sdate).ToString() + "��)";
                }
                else if (addmode == "2")
                {
                    return "�¼�(��" + DateOften.GetSeasonNum(sdate).ToString() + "��)";
                }
                else if (addmode == "3")
                {
                    return "ͬ��(��" + DateOften.GetSeasonNum(sdate).ToString() + "��)";
                }
            }
            else if (cmode == "4")
            {
                if (addmode == "0")
                {
                    return "������(" + DateOften.GetSemiyearly(sdate).ToString() + ")";
                }
                else if (addmode == "1")
                {
                    return "�ϰ���(" + DateOften.GetSemiyearly(sdate).ToString() + ")";
                }
                else if (addmode == "2")
                {
                    return "�°���(" + DateOften.GetSemiyearly(sdate).ToString() + ")";
                }
                else if (addmode == "3")
                {
                    return "ͬ��(" + DateOften.GetSemiyearly(sdate).ToString() + ")";
                }
            }
            else if (cmode == "5")
            {
                DateTime rq = DateTime.Now;
                if (Often.IsDate(sdate))
                {
                    rq = Convert.ToDateTime(sdate);
                }
                int y = rq.Year;
                if (addmode == "0")
                {
                    return "�����(" + y.ToString() + "��)";
                }
                else if (addmode == "1")
                {
                    return "�����(" + y.ToString() + "��)";
                }
                else if (addmode == "2")
                {
                    return "�����(" + y.ToString() + "��)";
                }
                else if (addmode == "3")
                {
                    return "ͬ��(" + y.ToString() + "��)";
                }
            }
            else
            {
                if (addmode == "0")
                {
                    return "����";
                }
                else if (addmode == "1")
                {
                    return "����";
                }
                else if (addmode == "2")
                {
                    return "����";
                }
                else if (addmode == "3")
                {
                    return "ͬ��";
                }
            }
            return "";
        }
    }
}

