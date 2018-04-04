using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Text.RegularExpressions;

namespace App
{
    /// <summary>�ļ����ļ��о�̬������</summary>
    [Serializable]
    public static class FileSys
    {
        /// <summary>������������ʱ�����Ĵ������</summary>
        private static Exception _Exception;

        /// <summary>������������ʱ�����Ĵ������</summary>
        public static Exception OperError
        {
            get { return FileSys._Exception; }
            set { FileSys._Exception = value; }
        }

        /// <summary>�½��ļ�</summary>
        /// <param name="inPath">��Ҫ�½����ļ�ȫ·��</param>
        /// <returns>�ɹ����� true ʧ�ܷ��� false</returns>
        public static bool NewFile(string inPath)
        {
            return NewFile(inPath, true);
        }

        /// <summary>�½��ļ�</summary>
        /// <param name="inPath">��Ҫ�½����ļ�ȫ·��</param>
        /// <param name="isWrite">��ֵΪtrue,�򴴽�����д�ļ�������ֻ�����ļ�</param>
        /// <returns>�ɹ����� true ʧ�ܷ��� false</returns>
        public static bool NewFile(string inPath, bool isWrite)
        {
            _Exception=null;
            try
            {
                if (isWrite)
                {
                    File.Create(inPath);
                }
                else 
                {
                    if (!File.Exists(inPath))
                    {
                        File.Create(inPath);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                _Exception = ex;
                return false;
            }
        }

        /// <summary>ɾ���ļ�</summary>
        /// <param name="inPath">��Ҫɾ�����ļ�ȫ·��</param>
        /// <returns>�ɹ����� true ʧ�ܷ��� false</returns>
        public static bool DelFile(string inPath)
        {
            _Exception = null;
            try
            {
                if (File.Exists(inPath))
                {
                    File.Delete(inPath);
                } 
                return true;
            }
            catch (Exception ex)
            {
                _Exception = ex;
                return false;
            }
        }

        /// <summary>ȡ���ļ�ֻ������</summary>
        /// <param name="inPath">��Ҫȡ��ֻ�����Ե��ļ�ȫ·��</param>
        /// <returns>ȡ���ɹ����� true ʧ�ܷ��� false</returns>
        public static bool SetFileNormal(string inPath)
        {
            _Exception = null;
            try
            {
                if (File.Exists(inPath))
                {
                    FileInfo fi = new FileInfo(inPath);
                    if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                    {
                        fi.Attributes = FileAttributes.Normal;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                _Exception = ex;
                return false;
            }
        }

        /// <summary>�����ļ�·���ڵ��ļ���</summary>
        /// <param name="paths">�ļ�·��</param>
        /// <returns>�����ļ�·���ڵ��ļ���</returns>
        public static string GetFileName(string paths) 
        {
            try
            {
                return paths.Substring(paths.LastIndexOf("\\") + 1, (paths.LastIndexOf(".") - paths.LastIndexOf("\\") - 1)).Trim();
            }
            catch 
            {
                return "";
            }   
        }

        /// <summary>�����ļ�·���ڵ��ļ���չ��</summary>
        /// <param name="paths">�ļ�·��</param>
        /// <returns>�����ļ�·���ڵ��ļ���չ��</returns>
        public static string GetFileExtension(string paths) 
        {
            try
            {
                return paths.Substring(paths.LastIndexOf(".") + 1, (paths.Length - paths.LastIndexOf(".") - 1)).Trim();
            }
            catch
            {
                return "";
            }     
        }

        /// <summary>�½��ļ��У��½��ɹ����� true �½�ʧ�ܷ��� false</summary>
        /// <param name="path">Ҫ�½����ļ���·����·��ĩβ����Я��"\"��</param>
        /// <returns>�½��ɹ����� true �½�ʧ�ܷ��� false</returns>
        public static bool NewDir(string path)
        {
            string errStr = "";
            return NewDir(path, ref errStr);
        }

        /// <summary>�ƶ��ļ��У��ƶ��ɹ����� true �ƶ�ʧ�ܷ��� false</summary>
        /// <param name="path">Ҫ�ƶ����ļ���·����·��ĩβ����Я��"\"��</param>
        /// <param name="mpath">�ƶ�����Ŀ��·����·��ĩβ����Я��"\"��</param>
        /// <returns>�ƶ��ɹ����� true �ƶ�ʧ�ܷ��� false</returns>
        public static bool MoveDir(string path, string mpath)
        {
            string errStr = "";
            return MoveDir(path, mpath, ref errStr);
        }

        /// <summary>�����ļ��У����Ƴɹ����� true ����ʧ�ܷ��� false</summary>
        /// <param name="path">Ҫ���Ƶ��ļ���·����·��ĩβ����Я��"\"��</param>
        /// <param name="mpath">���Ƶ���Ŀ��·����·��ĩβ����Я��"\"��</param>
        /// <returns>���Ƴɹ����� true ����ʧ�ܷ��� false</returns>
        public static bool CopyDir(string path, string mpath)
        {
            string errStr = "";
            return CopyDir(path, mpath, ref errStr);
        }

        /// <summary>ɾ���ļ��У�ɾ���ɹ����� true ɾ��ʧ�ܷ��� false</summary>
        /// <param name="path">Ҫɾ�����ļ���·����·��ĩβ����Я��"\"��</param>
        /// <returns>ɾ���ɹ����� true ɾ��ʧ�ܷ��� false</returns>
        public static bool DelDir(string path)
        {
            string errStr = "";
            return DelDir(path, ref errStr);
        }

        /// <summary>�½��ļ��У��½��ɹ����� true �½�ʧ�ܷ��� false</summary>
        /// <param name="path">Ҫ�½����ļ���·����·��ĩβ����Я��"\"��</param>
        /// <param name="errStr">��������ʱ���صĴ�����Ϣ</param>
        /// <returns>�½��ɹ����� true �½�ʧ�ܷ��� false</returns>
        public static bool NewDir(string path,ref string errStr)
        {
            _Exception = null;
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
                return true;
            }
            catch (Exception ex)
            {
                _Exception = ex;
                errStr = ex.Message;
                return false;
            }
        }

        /// <summary>�ƶ��ļ��У��ƶ��ɹ����� true �ƶ�ʧ�ܷ��� false</summary>
        /// <param name="path">Ҫ�ƶ����ļ���·����·��ĩβ����Я��"\"��</param>
        /// <param name="mpath">�ƶ�����Ŀ��·����·��ĩβ����Я��"\"��</param>
        /// <param name="errStr">��������ʱ���صĴ�����Ϣ</param>
        /// <returns>�ƶ��ɹ����� true �ƶ�ʧ�ܷ��� false</returns>
        public static bool MoveDir(string path, string mpath, ref string errStr)
        {
            _Exception = null;
            try
            {
                Directory.Move(Path.GetDirectoryName(path), Path.GetDirectoryName(mpath));
                return true;
            }
            catch (Exception ex)
            {
                _Exception = ex;
                errStr = ex.Message;
                return false;
            }
        }

        /// <summary>�����ļ��У����Ƴɹ����� true ����ʧ�ܷ��� false</summary>
        /// <param name="path">Ҫ���Ƶ��ļ���·����·��ĩβ����Я��"\"��</param>
        /// <param name="mpath">���Ƶ���Ŀ��·����·��ĩβ����Я��"\"��</param>
        /// <param name="errStr">��������ʱ���صĴ�����Ϣ</param>
        /// <returns>���Ƴɹ����� true ����ʧ�ܷ��� false</returns>
        public static bool CopyDir(string path, string mpath, ref string errStr)
        {
            _Exception = null;
            try
            {
                path = Path.GetDirectoryName(path);
                mpath = Path.GetDirectoryName(mpath);
                CopyDirs(path, mpath);
                return true;
            }
            catch (Exception ex)
            {
                _Exception = ex;
                errStr = ex.Message;
                return false;
            }
        }

        /// <summary>�����ļ��в���</summary>
        /// <param name="path">Ҫ���Ƶ��ļ���·����·��ĩβ����Я��"\"��</param>
        /// <param name="mpath">���Ƶ���Ŀ��·����·��ĩβ����Я��"\"��</param>
        public static void CopyDirs(string path, string mpath)
        {
            _Exception = null;
            try
            {
                // ���Ŀ��Ŀ¼�Ƿ���Ŀ¼�ָ��ַ�����������������֮ 
                if (mpath[mpath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    mpath += Path.DirectorySeparatorChar;
                }
                // �ж�Ŀ��Ŀ¼�Ƿ����������������½�֮ 
                if (!Directory.Exists(mpath))
                {
                    Directory.CreateDirectory(mpath);
                }
                // �õ�ԴĿ¼���ļ��б��������ǰ����ļ��Լ�Ŀ¼·����һ������  
                string[] fileList = Directory.GetFileSystemEntries(path);
                // �������е��ļ���Ŀ¼ 
                foreach (string file in fileList)
                {
                    // �ȵ���Ŀ¼��������������Ŀ¼�͵ݹ�Copy��Ŀ¼������ļ� 
                    if (Directory.Exists(file))
                    {
                        CopyDirs(file, mpath + Path.GetFileName(file));
                    }
                    else
                    {
                        File.Copy(file, mpath + Path.GetFileName(file), true);
                    }
                }
            }
            catch (Exception ex)
            {
                _Exception = ex;
            }
        }

        /// <summary>ɾ���ļ��У�ɾ���ɹ����� true ɾ��ʧ�ܷ��� false</summary>
        /// <param name="path">Ҫɾ�����ļ���·����·��ĩβ����Я��"\"��</param>
        /// <param name="errStr">��������ʱ���صĴ�����Ϣ</param>
        /// <returns>ɾ���ɹ����� true ɾ��ʧ�ܷ��� false</returns>
        public static bool DelDir(string path, ref string errStr)
        {
            _Exception = null;
            try
            {
                string p = Path.GetDirectoryName(path);
                if (Directory.Exists(p))
                {
                    Directory.Delete(p, true);
                }    
                return true;
            }
            catch (Exception ex)
            {
                _Exception = ex;
                errStr = ex.Message;
                return false;
            }
        }

        /// <summary>ȡ���ļ���ֻ������</summary>
        /// <param name="inPath">��Ҫȡ��ֻ�����Ե��ļ���ȫ·��</param>
        /// <returns>ȡ���ɹ����� true ʧ�ܷ��� false</returns>
        public static bool SetDirNormal(string inPath)
        {
            _Exception = null;
            try
            {
                string p = Path.GetDirectoryName(inPath);
                if (Directory.Exists(p))
                {
                    DirectoryInfo DirInfo = new DirectoryInfo(p);
                    DirInfo.Attributes = FileAttributes.Normal & FileAttributes.Directory;
                }
                return true;
            }
            catch(Exception ex)
            {
                _Exception = ex;
                return false;
            }
        }

        /// <summary>ȡ���ļ����������ļ����ļ���ֻ������</summary>
        /// <param name="inPath">��Ҫȡ��ֻ�����Ե��ļ���ȫ·��</param>
        /// <returns>ȡ���ɹ����� true ʧ�ܷ��� false</returns>
        public static bool SetAllDirFileNormal(string inPath)
        {
            _Exception = null;
            try
            {
                List<string> files = new List<string>();
                List<string> paths = new List<string>();
                GetAllDirFiles(inPath, 9999999, ref files, ref paths);
                for (int i = 0; i < files.Count ; i++ )
                {
                    SetFileNormal(files[i]);
                    SetDirNormal(files[i]);
                }
                for (int i = 0; i < paths.Count; i++)
                {
                    SetDirNormal(paths[i]);
                }
                return true;
            }
            catch (Exception ex)
            {
                _Exception = ex;
                return false;
            }
        }

        /// <summary>��ȡָ��Ŀ¼��(��Ŀ¼������1000��)�����ļ����·�������ļ������·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="thispath">��·��</param>
        /// <param name="files">���������ļ����·���б�</param>
        /// <param name="paths">�������п��ļ������·���б�</param>
        public static void GetAllDirFiles(string path, string thispath, ref List<string> files, ref List<string> paths)
        {
            int lv = 0;
            pGetAllDirFiles(path, thispath, "", "", 1000, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼��(��Ŀ¼������1000��)�����ļ�·�������ļ���·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="files">���������ļ�·���б�</param>
        /// <param name="paths">�������п��ļ���·���б�</param>
        public static void GetAllDirFiles(string path, ref List<string> files, ref List<string> paths)
        {
            int lv = 0;
            pGetAllDirFiles(path, "", "", 1000, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼�������ļ����·�������ļ������·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="thispath">��·��</param>
        /// <param name="dirlv">��Ŀ¼������</param>
        /// <param name="files">���������ļ����·���б�</param>
        /// <param name="paths">�������п��ļ������·���б�</param>
        public static void GetAllDirFiles(string path, string thispath, int dirlv, ref List<string> files, ref List<string> paths)
        {
            int lv = 0;
            pGetAllDirFiles(path, thispath, "", "", dirlv, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼�������ļ�·�������ļ���·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="dirlv">��Ŀ¼������</param>
        /// <param name="files">���������ļ�·���б�</param>
        /// <param name="paths">�������п��ļ���·���б�</param>
        public static void GetAllDirFiles(string path, int dirlv, ref List<string> files, ref List<string> paths)
        {
            int lv = 0;
            pGetAllDirFiles(path, "", "", dirlv, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼��(��Ŀ¼������1000��)�����ļ����·�������ļ������·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="thispath">��·��</param>
        /// <param name="files">���������ļ����·���б�</param>
        /// <param name="paths">�������п��ļ������·���б�</param>
        /// <param name="searchpath">Ҫ��path�е�Ŀ¼��ƥ��������ַ���</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        public static void GetAllDirFiles(string path, string thispath, ref List<string> files, ref List<string> paths, string searchpath, string searchfile)
        {
            int lv = 0;
            pGetAllDirFiles(path, thispath, searchpath, searchfile, 1000, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼��(��Ŀ¼������1000��)�����ļ�·�������ļ���·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="files">���������ļ�·���б�</param>
        /// <param name="paths">�������п��ļ���·���б�</param>
        /// <param name="searchpath">Ҫ��path�е�Ŀ¼��ƥ��������ַ���</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        public static void GetAllDirFiles(string path, ref List<string> files, ref List<string> paths, string searchpath, string searchfile)
        {
            int lv = 0;
            pGetAllDirFiles(path, searchpath, searchfile, 1000, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼�������ļ����·�������ļ������·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="thispath">��·��</param>
        /// <param name="dirlv">��Ŀ¼������</param>
        /// <param name="files">���������ļ����·���б�</param>
        /// <param name="paths">�������п��ļ������·���б�</param>
        /// <param name="searchpath">Ҫ��path�е�Ŀ¼��ƥ��������ַ���</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        public static void GetAllDirFiles(string path, string thispath, int dirlv, ref List<string> files, ref List<string> paths, string searchpath, string searchfile)
        {
            int lv = 0;
            pGetAllDirFiles(path, thispath, searchpath, searchfile, dirlv, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼�������ļ�·�������ļ���·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="dirlv">��Ŀ¼������</param>
        /// <param name="files">���������ļ�·���б�</param>
        /// <param name="paths">�������п��ļ���·���б�</param>
        /// <param name="searchpath">Ҫ��path�е�Ŀ¼��ƥ��������ַ���</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        public static void GetAllDirFiles(string path, int dirlv, ref List<string> files, ref List<string> paths, string searchpath, string searchfile)
        {
            int lv = 0;
            pGetAllDirFiles(path, searchpath, searchfile, dirlv, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼��(��Ŀ¼������1000��)�����ļ����·�������ļ������·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="thispath">��·��</param>
        /// <param name="files">���������ļ����·���б�</param>
        /// <param name="paths">�������п��ļ������·���б�</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        public static void GetAllDirFiles(string path, string thispath, ref List<string> files, ref List<string> paths, string searchfile)
        {
            int lv = 0;
            pGetAllDirFiles(path, thispath, "", searchfile, 1000, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼��(��Ŀ¼������1000��)�����ļ�·�������ļ���·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="files">���������ļ�·���б�</param>
        /// <param name="paths">�������п��ļ���·���б�</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        public static void GetAllDirFiles(string path, ref List<string> files, ref List<string> paths, string searchfile)
        {
            int lv = 0;
            pGetAllDirFiles(path, "", searchfile, 1000, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼�������ļ����·�������ļ������·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="thispath">��·��</param>
        /// <param name="dirlv">��Ŀ¼������</param>
        /// <param name="files">���������ļ����·���б�</param>
        /// <param name="paths">�������п��ļ������·���б�</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        public static void GetAllDirFiles(string path, string thispath, int dirlv, ref List<string> files, ref List<string> paths, string searchfile)
        {
            int lv = 0;
            pGetAllDirFiles(path, thispath, "", searchfile, dirlv, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼�������ļ�·�������ļ���·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="dirlv">��Ŀ¼������</param>
        /// <param name="files">���������ļ�·���б�</param>
        /// <param name="paths">�������п��ļ���·���б�</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        public static void GetAllDirFiles(string path, int dirlv, ref List<string> files, ref List<string> paths, string searchfile)
        {
            int lv = 0;
            pGetAllDirFiles(path, "", searchfile, dirlv, ref files, ref paths, ref lv);
        }

        /// <summary>��ȡָ��Ŀ¼�������ļ����·�������ļ������·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="thispath">��·��</param>
        /// <param name="searchpath">Ҫ��path�е�Ŀ¼��ƥ��������ַ���</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        /// <param name="dirlv">��Ŀ¼������</param>
        /// <param name="files">���������ļ����·���б�</param>
        /// <param name="paths">�������п��ļ������·���б�</param>
        /// <param name="lv">��ǰĿ¼���</param>
        private static void pGetAllDirFiles(string path, string thispath, string searchpath, string searchfile, int dirlv, ref List<string> files, ref List<string> paths, ref int lv)
        {
            lv++;
            if (lv > dirlv) 
            {
                return;
            }
            string[] subPaths;
            if (searchpath.Trim() == "")
            {
                subPaths = Directory.GetDirectories(path);
            }
            else 
            {
                subPaths = Directory.GetDirectories(path, searchpath);
            }
            foreach (string ph in subPaths)
            {
                pGetAllDirFiles(ph, thispath, searchpath, searchfile, dirlv, ref files, ref paths, ref lv);
            }
            string[] fs;
            if (searchfile.Trim() == "")
            {
                fs = Directory.GetFiles(path);
            }
            else
            {
                fs = Directory.GetFiles(path, searchfile);
            }
            foreach (string file in fs)
            {
                string sfile = file;
                sfile = sfile.Replace("/", "\\");
                sfile = sfile.Remove(0, thispath.Length);
                if (files.IndexOf(sfile) == -1)
                {
                    files.Add(sfile);
                }
            }
            if (subPaths.Length == fs.Length && fs.Length == 0)
            {
                path = path.Replace("/", "\\");
                path = path.Remove(0, thispath.Length);
                if (paths.IndexOf(path) == -1)
                {
                    paths.Add(path);
                }
            }
        }

        /// <summary>��ȡָ��Ŀ¼�������ļ�·�������ļ���·�����ֱ𷵻ص�files��paths</summary>
        /// <param name="path">ָ��Ŀ¼(����·��)</param>
        /// <param name="searchpath">Ҫ��path�е�Ŀ¼��ƥ��������ַ���</param>
        /// <param name="searchfile">Ҫ��path�е��ļ���ƥ��������ַ���</param>
        /// <param name="dirlv">��Ŀ¼������</param>
        /// <param name="files">���������ļ�·���б�</param>
        /// <param name="paths">�������п��ļ���·���б�</param>
        /// <param name="lv">��ǰĿ¼���</param>
        private static void pGetAllDirFiles(string path, string searchpath, string searchfile, int dirlv, ref List<string> files, ref List<string> paths, ref int lv)
        {
            lv++;
            if (lv > dirlv)
            {
                return;
            }
            string[] subPaths;
            if (searchpath.Trim() == "")
            {
                subPaths = Directory.GetDirectories(path);
            }
            else
            {
                subPaths = Directory.GetDirectories(path, searchpath);
            }
            foreach (string ph in subPaths)
            {
                pGetAllDirFiles(ph, searchpath, searchfile, dirlv, ref files, ref paths, ref lv);
            }
            string[] fs;
            if (searchfile.Trim() == "")
            {
                fs = Directory.GetFiles(path);
            }
            else
            {
                fs = Directory.GetFiles(path, searchfile);
            }
            foreach (string file in fs)
            {
                string fstr = file.Replace("/","\\");
                if (files.IndexOf(fstr) == -1)
                {
                    files.Add(fstr);
                }
            }
            if (subPaths.Length == fs.Length && fs.Length == 0)
            {
                string pstr = path.Replace("/", "\\");
                if (paths.IndexOf(pstr) == -1) 
                {
                    paths.Add(pstr);
                }
            }
        }

        /// <summary>����ָ���ļ���MD5Hash��ֵ</summary>
        /// <param name="path">�ļ�·��</param>
        /// <returns>����ָ���ļ���MD5Hash��ֵ</returns>
        public static string GetFileMD5Hash(string path)
        {
            string err="";
            return GetFileMD5Hash(path, ref err);
        }

        /// <summary>����ָ���ļ���MD5Hash��ֵ</summary>
        /// <param name="path">�ļ�·��</param>
        /// <param name="err">�������󷵻صĴ�����Ϣ</param>
        /// <returns>����ָ���ļ���MD5Hash��ֵ</returns>
        public static string GetFileMD5Hash(string path, ref string err)
        {
            try
            {
                FileStream get_file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                System.Security.Cryptography.MD5CryptoServiceProvider getHash = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] hash_byte = getHash.ComputeHash(get_file);
                string resule = System.BitConverter.ToString(hash_byte);
                resule = resule.Replace("-", "");
                return resule;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return "";
        }

        /// <summary>����ָ���ļ���SHA1Hash��ֵ</summary>
        /// <param name="path">�ļ�·��</param>
        /// <returns>����ָ���ļ���SHA1Hash��ֵ</returns>
        public static string GetFileSHA1Hash(string path)
        {
            string err="";
            return GetFileSHA1Hash(path, ref err);
        }

        /// <summary>����ָ���ļ���SHA1Hash��ֵ</summary>
        /// <param name="path">�ļ�·��</param>
        /// <param name="err">�������󷵻صĴ�����Ϣ</param>
        /// <returns>����ָ���ļ���SHA1Hash��ֵ</returns>
        public static string GetFileSHA1Hash(string path, ref string err)
        {
            try
            {
                FileStream get_file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                System.Security.Cryptography.SHA1CryptoServiceProvider getHash = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                byte[] hash_byte = getHash.ComputeHash(get_file);
                string resule = System.BitConverter.ToString(hash_byte);
                resule = resule.Replace("-", "");
                return resule;
            }
            catch (Exception ex)
            {
                err = ex.Message;
            }
            return "";
        }

        /// <summary>���ص�ǰ��������·��</summary>
        /// <returns>���ص�ǰ��������·��</returns>
        public static string GetAssemblyPath()
        {
            string _CodeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            _CodeBase = _CodeBase.Substring(8, _CodeBase.Length - 8); // 8�� file:// �ĳ���   
            string[] arrSection = _CodeBase.Split(new char[] { '/' });
            string _FolderPath = "";
            for (int i = 0; i < arrSection.Length - 1; i++)
            {
                _FolderPath += arrSection[i] + "/";
            }
            return _FolderPath;
        }
    }
}

