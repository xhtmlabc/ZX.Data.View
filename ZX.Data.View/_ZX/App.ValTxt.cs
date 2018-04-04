using System;
using System.Text;
using System.ComponentModel;

namespace App
{
    /// <summary>�洢һ�������ı�ֵ</summary>
    [Serializable]
    public class ValTxt
    {
        #region ˽������

        /// <summary>��ȡ�����ý�(Ĭ��ֵ�����ַ���)</summary>
        private string _Value = "";

        /// <summary>��ȡ�������ı�ֵ(Ĭ��ֵ�����ַ���)</summary>
        private string _Text = "";

        #endregion

        #region ��������

        /// <summary>��ȡ�����ý�(Ĭ��ֵ�����ַ���)</summary>
        [Description("��(Ĭ��ֵ�����ַ���)")]
        public string Value
        {
            get { return _Value; }
            set { _Value = value; }
        }

        /// <summary>��ȡ�������ı�ֵ(Ĭ��ֵ�����ַ���)</summary>
        [Description("�ı�ֵ(Ĭ��ֵ�����ַ���)")]
        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }

        #endregion

        #region ������

        /// <summary>������</summary>
        /// <returns></returns>
        public ValTxt(){}

        /// <summary>ʹ�õ�һֵ��佡���ı�������</summary>
        /// <param name="value">ֵ(��ֵ����佡���ı�)</param>
        /// <returns></returns>
        public ValTxt(string value)
        {
            _Value = value;
            _Text = value;
        }

        /// <summary>ʹ�ý����ı�ֵ������</summary>
        /// <param name="value">��</param>
        /// <param name="text">�ı�ֵ</param>
        /// <returns></returns>
        public ValTxt(string value, string text)
        {
            _Value = value;
            _Text = text;
        }

        #endregion

        #region ��������

        /// <summary>�����ı�ֵ</summary>
        /// <returns>�����ı�ֵ</returns>
        public override string ToString()
        {
            return _Text;
        }

        #endregion
    }
}

