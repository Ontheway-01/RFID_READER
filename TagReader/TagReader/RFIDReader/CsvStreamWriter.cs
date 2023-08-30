using System;
using System.Text;
using System.Collections;
using System.IO;
using System.Data;

namespace TagReader.RFIDReader
{
    #region 类说明信息
    /// <summary>
    ///  <DL>
    ///  <DT><b>写CSV文件类,首先给CSV文件赋值,最后通过Save方法进行保存操作</b></DT>
    ///   <DD>
    ///    <UL> 
    ///    </UL>
    ///   </DD>
    ///  </DL>
    ///  <Author>yangzhihong</Author>   
    ///  <CreateDate>2006/01/16</CreateDate>
    ///  <Company></Company>
    ///  <Version>1.0</Version>
    /// </summary>
    #endregion
    public class CsvStreamWriter
    {
        private readonly ArrayList _rowAl;       // 줄 목록, CSV 파일의 모든 줄은 하나의 줄입니다.
        private string _fileName;       //文件名
        private Encoding _encoding;     //编码

        public CsvStreamWriter()
        {
            _rowAl = new ArrayList();
            _fileName = "";
            _encoding = Encoding.Default;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName">파일 경로 포함 파일 이름</param>
        public CsvStreamWriter(string fileName)
        {
            _rowAl = new ArrayList();
            _fileName = fileName;
            _encoding = Encoding.Default;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="fileName">파일 경로 포함 파일 이름</param>
        /// <param name="encoding">파일 인코딩</param>
        public CsvStreamWriter(string fileName, Encoding encoding)
        {
            _rowAl = new ArrayList();
            _fileName = fileName;
            _encoding = encoding;
        }

        /// <summary>
        /// row:行,row = 1代表第一行
        /// col:列,col = 1代表第一列
        /// </summary>
        public string this[int row, int col]
        {
            set
            {
                //행판단
                if (row <= 0)
                {
                    throw new Exception("행 수가 0보다 작을 수 없음");
                }
                if (row > _rowAl.Count) //현재 열 체인의 행 수가 부족하면 채워야 합니다
                {
                    for (var i = _rowAl.Count + 1; i <= row; i++)
                    {
                        _rowAl.Add(new ArrayList());
                    }
                }
                //열에 대한 판단

                if (col <= 0)
                {
                    throw new Exception("행 수가 0보다 작을 수 없음");
                }
                ArrayList colTempAl = (ArrayList)_rowAl[row - 1];

                //길이 확장

                if (col > colTempAl.Count)
                {
                    for (var i = colTempAl.Count; i <= col; i++)
                    {
                        colTempAl.Add("");
                    }
                }
                _rowAl[row - 1] = colTempAl;
                //할당
                ArrayList colAl = (ArrayList)_rowAl[row - 1];

                colAl[col - 1] = value;
                _rowAl[row - 1] = colAl;
            }
        }


        /// <summary>
        /// 파일 경로 포함 파일 이름
        /// </summary>
        public string FileName
        {
            set
            {
                _fileName = value;
            }
        }

        /// <summary>
        /// 文件编码
        /// </summary>
        public Encoding FileEncoding
        {
            set
            {
                _encoding = value;
            }
        }

        /// <summary>
        /// 获取当前最大行
        /// </summary>
        public int CurMaxRow
        {
            get { return _rowAl.Count; }
        }

        /// <summary>
        /// 获取最大列
        /// </summary>
        public int CurMaxCol
        {
            get
            {
                var maxCol = 0;
                for (int i = 0; i < _rowAl.Count; i++)
                {
                    ArrayList colAl = (ArrayList)_rowAl[i];

                    maxCol = (maxCol > colAl.Count) ? maxCol : colAl.Count;
                }

                return maxCol;
            }
        }

        /// <summary>
        /// CSV 파일에 테이블 데이터 추가
        /// </summary>
        /// <param name="dataDt">테이블 데이터</param>
        /// <param name="beginCol">몇 번째 열부터,beginCol = 1 대표 제일열</param>
        public void AddData(DataTable dataDt, int beginCol)
        {
            if (dataDt == null)
            {
                throw new Exception("需要添加的表数据为空");
            }

            var curMaxRow = _rowAl.Count;
            for (var i = 0; i < dataDt.Rows.Count; i++)
            {
                for (var j = 0; j < dataDt.Columns.Count; j++)
                {
                    this[curMaxRow + i + 1, beginCol + j] = dataDt.Rows[i][j].ToString();
                }
            }
        }

        /// <summary>
        /// 현재 하드 디스크에 파일 이름이 같은 파일이 이미 있으면 덮어쓰도록 데이터를 저장합니다.
        /// </summary>
        public void Save()
        {
            //데이터의 유효성에 대한 판단
            if (_fileName == null)
            {
                throw new Exception("缺少文件名");
            }
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            if (_encoding == null)
            {
                _encoding = Encoding.Default;
            }
            var sw = new StreamWriter(_fileName, false, _encoding);

            foreach (object t in _rowAl)
            {
                sw.WriteLine(ConvertToSaveLine((ArrayList)t));
            }

            sw.Close();
        }

        /// <summary>
        /// 현재 하드 디스크에 파일 이름이 같은 파일이 이미 있으면 덮어쓰도록 데이터를 저장합니다.
        /// </summary>
        /// <param name="fileName">文件名,包括文件路径</param>
        public void Save(string fileName)
        {
            _fileName = fileName;
            Save();
        }

        /// <summary>
        /// 현재 하드 디스크에 파일 이름이 같은 파일이 이미 있으면 덮어쓰도록 데이터를 저장합니다.
        /// </summary>
        /// <param name="fileName">文件名,包括文件路径</param>
        /// <param name="encoding">文件编码</param>
        public void Save(string fileName, Encoding encoding)
        {
            _fileName = fileName;
            _encoding = encoding;
            Save();
        }


        /// <summary>
        /// 转换成保存行
        /// </summary>
        /// <param name="colAl">一行</param>
        /// <returns></returns>
        private string ConvertToSaveLine(ArrayList colAl)
        {
            var saveLine = string.Empty;
            for (var i = 0; i < colAl.Count; i++)
            {
                saveLine += ConvertToSaveCell(colAl[i].ToString());
                //格子间以逗号分割
                if (i < colAl.Count - 1)
                {
                    saveLine += ",";
                }
            }
            return saveLine;
        }

        /// <summary>
        /// 문자열을 CSV의 칸으로 변환
        /// 큰따옴표를 두 개의 큰따옴표로 변환한 다음, 처음과 끝에 각각 큰따옴표를 붙입니다.
        /// 이렇게 하면 쉼표와 줄 바꿈을 고려할 필요가 없습니다.
        /// </summary>
        /// <param name="cell"> 격자 내용</param>
        /// <returns></returns>
        private string ConvertToSaveCell(string cell)
        {
            //cell = cell.Replace("/"" , "/"/"");

            //return "/"" + cell + "/"";

            cell = cell.Replace(@"""", @"""""");
            return @"""" + cell + @"""";
        }
    }
}