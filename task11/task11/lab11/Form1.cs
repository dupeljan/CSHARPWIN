using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.IO;
using System.Data.OleDb;
using System.Xml;

namespace lab11 {
    public partial class Form1 : Form {

        Double Counter = 4;
        OdbcConnection ConnectionODBC;

        String ConnetionStringOLE1 = null; // Переменная для сохранения данных соединения
        OleDbConnection ConnectionOLE1; // Объект для открытия подключения к базе данных
        String SQL_OLE = null; // Переменная для поискового запроса
        String SQL_OLE_ADD = null; // Переменная для добавления данных

        String ConnetionStringOLE2 = null;
        OleDbConnection ConnectionOLE2;
        String ConnetionStringOLE_S = null;
        OleDbConnection ConnectionOLE_S;
        OleDbDataAdapter DataAdapter_S;

        public Form1() {
            InitializeComponent();

            B_ODBC_Add.Enabled = false;
            B_ODBC_Connect.Enabled = false;
            B_ODBC_Disconnect.Enabled = false;

            B_OLE_1_Read.Enabled = false;
            B_OLE_1_Add.Enabled = false;
            TB_OLE_1_1.Text = Counter.ToString();
            SQL_OLE = "SELECT * FROM [Main_Table]";

            B_OLE_2_Read.Enabled = false;
            DataGridViewOLE.DataMember = "Table"; // Указываемнатипподспискадля DataGridView
        }

        private void B_ODBC_Search_Click(object sender, EventArgs e) {
            if (OFD_ODBC.ShowDialog() == DialogResult.OK) {
                B_ODBC_Add.Enabled = true;
                B_ODBC_Connect.Enabled = true;
                B_ODBC_Disconnect.Enabled = true;
                Directory.CreateDirectory(Path.GetDirectoryName(OFD_ODBC.FileName) + @"\Копии"); // СоздаёмдиректориюподизменённыеБД
                File.Copy(OFD_ODBC.FileName, Path.GetDirectoryName(OFD_ODBC.FileName) + @"\Копии\" + OFD_ODBC.SafeFileName, true); // КопируемтудавыбраннуюБД (перезаписываем, вслучаеобнаруженияпохожегофайла)
                if (Path.GetDirectoryName(OFD_ODBC.FileName) == Directory.GetDirectoryRoot(OFD_ODBC.FileName)) // Проверяемпуть, еслинаходимсявкорневойдиректориидиска, режемодинслеш
                    TB_ODBC_Path.Text = Path.GetDirectoryName(OFD_ODBC.FileName) + @"Копии\" + OFD_ODBC.SafeFileName;
                else
                    TB_ODBC_Path.Text = Path.GetDirectoryName(OFD_ODBC.FileName) + @"\Копии\" + OFD_ODBC.SafeFileName;
            }

        }

        private void B_ODBC_Connect_Click(object sender, EventArgs e) {
            String ConnetionStringODBC = null;
            ConnetionStringODBC = "Driver={Microsoft Access Driver (*.mdb)}; DBQ=" + TB_ODBC_Path.Text + ";"; // Выбираемисточникданных ("провайдера") иуказываемпутькнемучерез TextBox
            ConnectionODBC = new OdbcConnection(ConnetionStringODBC); // Инициализируемобъектсоединениясновымипараметрами

            try {
                ConnectionODBC.Open(); // Открываемсоединение
                MessageBox.Show("Соединение с базой данных " + TB_ODBC_Path.Text + " успешно открыто!", "Работа с базами данных (C#) :: ODBC");
            }
            catch (Exception ex) {
                MessageBox.Show("Невозможно открыть соединение с базой данных " + TB_ODBC_Path.Text + " (" + ex.Message + ")!", "Работа с базами данных (C#) :: ODBC");
            }
        }

        private void B_ODBC_Add_Click(object sender, EventArgs e) {
            String SQL_ODBC = "INSERT INTO \"Main_Table\" VALUES( '" + Counter++ + "', 'Число', '999', 'ABC' );"; // Запрос на на добавление записей в нашу таблицу, Main_Field будет числовым, начинается с 4 и далее растёт инкрементом
            OdbcCommand Command = new OdbcCommand(SQL_ODBC, ConnectionODBC); // Формируемкоманду
            try {
                Command.ExecuteNonQuery(); // Выполняемкоманду
                RTB_ODBC.Clear(); // Очищаем RichTextBox
                RTB_ODBC.AppendText(Command.CommandText); // Вставляем результат выполнения команды с нашей базой
            }
            catch (Exception ex) {
                RTB_ODBC.Clear();
                RTB_ODBC.AppendText(ex.Message);
            }
        }

        private void B_ODBC_Disconnect_Click(object sender, EventArgs e) {
            String SQL_ODBC = "DELETE FROM \"Main_Table\" WHERE \"Main_Table\".\"Field_1\" = 'Число';"; // Запрос на удаление всего добавленного (чтобы не делать это вручную потом)
            OdbcCommand Command = new OdbcCommand(SQL_ODBC, ConnectionODBC); // Формируемкоманду

            try {
                Command.ExecuteNonQuery(); // Выполняемкоманду
                RTB_ODBC.Clear(); // Очищаем RichTextBox
                RTB_ODBC.AppendText(Command.CommandText); // Вставляем результат выполнения команды с нашей базой
                ConnectionODBC.Close(); // Закрываем соединение
                MessageBox.Show("Соединение с базой данных " + TB_ODBC_Path.Text + " успешно закрыто!", "Работа с базами данных (C#) :: ODBC");
            }
            catch (Exception ex) {
                RTB_ODBC.Clear();
                RTB_ODBC.AppendText(ex.Message);
                MessageBox.Show("Невозможно закрыть соединение с базой данных " + TB_ODBC_Path.Text + " (" + ex.Message + ")!", "Работа с базами данных (C#) :: ODBC");
            }
        }

        private void B_OLE_1_Search_Click(object sender, EventArgs e) {
            if (OFD_OLE_1.ShowDialog() == DialogResult.OK) {
                B_OLE_1_Read.Enabled = true; // Активируем кнопку "Прочитать все записи"
                B_OLE_1_Add.Enabled = true;
                //TB_OLE_1_Path.Text = OFD_OLE_1.FileName;
                Directory.CreateDirectory(Path.GetDirectoryName(OFD_OLE_1.FileName) + @"\Копии"); // СоздаёмдиректориюподизменённыеБД
                File.Copy(OFD_OLE_1.FileName, Path.GetDirectoryName(OFD_OLE_1.FileName) + @"\Копии\" + OFD_OLE_1.SafeFileName, true); // КопируемтудавыбраннуюБД (перезаписываем, вслучаеобнаруженияпохожегофайла)
                if (Path.GetDirectoryName(OFD_OLE_1.FileName) == Directory.GetDirectoryRoot(OFD_OLE_1.FileName)) // Проверяемпуть, еслинаходимсявкорневойдиректориидиска, режемодинслеш
                    TB_OLE_1_Path.Text = Path.GetDirectoryName(OFD_OLE_1.FileName) + @"Копии\" + OFD_OLE_1.SafeFileName;
                else
                    TB_OLE_1_Path.Text = Path.GetDirectoryName(OFD_OLE_1.FileName) + @"\Копии\" + OFD_OLE_1.SafeFileName;

                if (Path.GetExtension(OFD_OLE_1.FileName) == ".mdb") // Узнаём расширение файла выбранного в диалоге открытия (указываем полный путь) и сравниваем его с ".mdb"
                {
                    ConnetionStringOLE1 = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + TB_OLE_1_Path.Text + "";
                    MessageBox.Show("Выбрана база данных " + TB_OLE_1_Path.Text + " формата: *" + Path.GetExtension(TB_OLE_1_Path.Text) + "!", "Работасбазамиданных (C#) :: OLE # 1");
                }

                if (Path.GetExtension(OFD_OLE_1.FileName) == ".accdb") {
                    ConnetionStringOLE1 = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=" + TB_OLE_1_Path.Text + "";
                    MessageBox.Show("Выбранабазаданных " + TB_OLE_1_Path.Text + " формата: *" + Path.GetExtension(TB_OLE_1_Path.Text) + "!", "Работасбазамиданных (C#) :: OLE # 1");
                }
            }
        }

        private void B_OLE_1_Read_Click(object sender, EventArgs e) {
            LB_OLE_1.Items.Clear();
            ConnectionOLE1 = new OleDbConnection(ConnetionStringOLE1);

            try {
                ConnectionOLE1.Open(); // Открываемсоединение
                MessageBox.Show("Соединение с базой данных " + TB_OLE_1_Path.Text + " успешно открыто!", "Работа с базами данных (C#) :: OLE # 1");
            }
            catch (Exception ex) // Ловимисключениеивытаскиваемошибкучерезex.Message
            {
                MessageBox.Show("Невозможно открыть соединение с базой данных " + TB_OLE_1_Path.Text + " (" + ex.Message + ")!", "Работа с базами данных (C#) :: OLE # 1");
            }
            OleDbCommand Command = new OleDbCommand(SQL_OLE, ConnectionOLE1); // Формируем SQL-команду для текущего подключения
            OleDbDataReader DataReader = Command.ExecuteReader(); // Формируем объект для чтения данных из базы данных
            LB_OLE_1.Items.Add(Command.CommandText); // Посылаем текст команды в ListBox
                                                     // Организуем циклический перебор полученных записей
            while (DataReader.Read()) {
                LB_OLE_1.Items.Add(DataReader["Main_Field"].ToString() + " | " + DataReader["Field_1"].ToString() + " | " + DataReader["Field_2"].ToString() + " | " + DataReader["Field_3"].ToString());
            }
            // Закрываем потоки чтения и соединения
            DataReader.Close();
            ConnectionOLE1.Close();
        }

        private void B_OLE_1_Add_Click(object sender, EventArgs e) {
            LB_OLE_1.Items.Clear(); // Очищаем ListBox передиспользованием
            ConnectionOLE1 = new OleDbConnection(ConnetionStringOLE1); // Передаёмпараметрыобъектусоединения

            try {
                ConnectionOLE1.Open(); // Открываемсоединение
                MessageBox.Show("Соединение с базой данных " + TB_OLE_1_Path.Text + " успешно открыто!", "Работа с базами данных (C#) :: OLE # 1");
            }
            catch (Exception ex) {
                MessageBox.Show("Невозможно открыть соединение с базой данных " + TB_OLE_1_Path.Text + " (" + ex.Message + ")!", "Работа с базами данных (C#) :: OLE # 1");
            }
            SQL_OLE_ADD = "INSERT INTO [Main_Table] VALUES('" + Counter.ToString() + "', '" + this.TB_OLE_1_2.Text + "', '" + this.TB_OLE_1_3.Text + "', '" + this.TB_OLE_1_4.Text + "');";
            OleDbCommand Command = new OleDbCommand(SQL_OLE_ADD, ConnectionOLE1);

            try {
                Command.ExecuteNonQuery(); // Выполняемкоманду
            }
            catch (Exception ex) {
                MessageBox.Show("Невозможно выполнить команду с базой данных " + TB_OLE_1_Path.Text + " (" + ex.Message + ")!", "Работа с базами данных (C#) :: OLE # 1");
            }
            LB_OLE_1.Items.Add(Command.CommandText); // Отправляемтексткомандыв ListBox
            Counter++;
            TB_OLE_1_1.Text = Counter.ToString();
        }

        private void Form1_Load(object sender, EventArgs e) {

            String provider,fileExtension;
            if (DialogResult.Yes == MessageBox.Show("У вас 64-разрядный проект?(Использовать лишь *.accdb)", "Предварительная настройка", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {
                provider = "Provider=Microsoft.ACE.OLEDB.12.0;";
                fileExtension = ".accdb";
                GB_ODBC.Visible = false;
            }
            else {
                provider = "Provider=Microsoft.Jet.OLEDB.4.0;";
                fileExtension = ".mdb";
            }

            String directory = @"C:\Users\Ibrag\Desktop\C#\Lab Works\Programms\lab11\";
 
            Directory.CreateDirectory(directory + @"\Копии");
            File.Copy(directory + "LWP10-DB-OLE-Special" + fileExtension, directory + @"\Копии\" + @"LWP10-DB-OLE-Special" + fileExtension, true);

            ConnetionStringOLE_S = provider + @"Data Source="+directory+@"Копии\LWP10-DB-OLE-Special" + fileExtension;
            ConnectionOLE_S = new OleDbConnection(ConnetionStringOLE_S);

            try {
                ConnectionOLE_S.Open(); // Открываем соединение
                MessageBox.Show("Соединение с базой данных LWP10-DB-OLE-Special"+fileExtension+" успешно открыто!", "Работа с базами данных (C#) :: OLE # 2");
            }
            catch (Exception ex) {
                MessageBox.Show("Невозможно открыть соединение с базой данных LWP10-DB-OLE-Special"+fileExtension+" (" + ex.Message + ")!", "Работа с базами данных (C#) :: OLE # 2");
            }
            DataTable DataTable_S = new DataTable();
            // Создаёмкоманду
            OleDbCommand Command = new OleDbCommand("SELECT * FROM Main_Table", ConnectionOLE_S);
            // Создаём адаптер DataAdapter_S: посредник между базой данных и DataSet
            DataAdapter_S = new OleDbDataAdapter(Command);
            // Создаём построитель команд
            // Для адаптера становится доступной команда Update и другие команды
            OleDbCommandBuilder CommandBuilder = new OleDbCommandBuilder(DataAdapter_S);
            // Данные из адаптера поступают в DataTable_S
            DataAdapter_S.Fill(DataTable_S);
            // Связываемданныесэлементом DataGridView
            DataGridViewOLE_S.DataSource = DataTable_S;
            // Закрываем соединение
            ConnectionOLE_S.Close();
        }

        private void B_OLE_2_Search_Click(object sender, EventArgs e) {
            if (OFD_OLE_2.ShowDialog() == DialogResult.OK) {
                B_OLE_2_Read.Enabled = true;
                B_OLE_2_Save.Enabled = true;
                //TB_OLE_2_Path.Text = OFD_OLE_2.FileName;
                Directory.CreateDirectory(Path.GetDirectoryName(OFD_OLE_2.FileName) + @"\Копии"); // СоздаёмдиректориюподизменённыеБД
                File.Copy(OFD_OLE_2.FileName, Path.GetDirectoryName(OFD_OLE_2.FileName) + @"\Копии\" + OFD_OLE_2.SafeFileName, true); // КопируемтудавыбраннуюБД (перезаписываем, вслучаеобнаруженияпохожегофайла)
                if (Path.GetDirectoryName(OFD_OLE_2.FileName) == Directory.GetDirectoryRoot(OFD_OLE_2.FileName)) // Проверяемпуть, еслинаходимсявкорневойдиректориидиска, режемодинслеш
                    TB_OLE_2_Path.Text = Path.GetDirectoryName(OFD_OLE_2.FileName) + @"Копии\" + OFD_OLE_2.SafeFileName;
                else
                    TB_OLE_2_Path.Text = Path.GetDirectoryName(OFD_OLE_2.FileName) + @"\Копии\" + OFD_OLE_2.SafeFileName;

                if (Path.GetExtension(OFD_OLE_2.FileName) == ".mdb") {
                    ConnetionStringOLE2 = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + TB_OLE_2_Path.Text + "";
                    MessageBox.Show("Выбрана база данных " + TB_OLE_2_Path.Text + " формата: *" + Path.GetExtension(TB_OLE_2_Path.Text) + "!", "Работасбазамиданных (C#) :: OLE # 2");
                }

                if (Path.GetExtension(OFD_OLE_2.FileName) == ".accdb") {
                    ConnetionStringOLE2 = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=" + TB_OLE_2_Path.Text + "";
                    MessageBox.Show("Выбрана база данных " + TB_OLE_2_Path.Text + " формата: *" + Path.GetExtension(TB_OLE_2_Path.Text) + "!", "Работасбазамиданных (C#) :: OLE # 2");
                }
            }
        }

        private void B_OLE_2_Read_Click(object sender, EventArgs e) {
            DataSetOLE.Clear(); // Очищаем DataSetOLE перед повторным заполнением из базы данных
            ConnectionOLE2 = new OleDbConnection(ConnetionStringOLE2);

            try {
                ConnectionOLE2.Open(); // Открываемсоединение
                MessageBox.Show("Соединение с базой данных " + TB_OLE_2_Path.Text + " успешно открыто!", "Работа с базами данных (C#) :: OLE # 2");
            }
            catch (Exception ex) {
                MessageBox.Show("Невозможно открыть соединение с базой данных " + TB_OLE_2_Path.Text + " (" + ex.Message + ")!", "Работа с базами данных (C#) :: OLE # 2");
            }
            // Создаем объект DataAdapter и передаём ему данные запроса
            OleDbDataAdapter DataAdapter = new OleDbDataAdapter(); // DataAdapter - посредник между базой данных и DataSet
            DataAdapter.SelectCommand = new OleDbCommand(SQL_OLE, ConnectionOLE2);
            DataAdapter.Fill(DataSetOLE); // Данные из адаптера поступают в DataSet
            DataGridViewOLE.DataSource = DataSetOLE; // Связываем данные с элементом DataGridView
                                                     // Закрываем соединение
            ConnectionOLE2.Close();
        }

        private void B_OLE_2_Save_Click(object sender, EventArgs e) {
            try {
                DataAdapter_S.Update((DataTable)DataGridViewOLE_S.DataSource);
                MessageBox.Show("Изменения в базе данных LWP10-DB-OLE-Special.accdb успешно внесены!", "Работа с базами данных (C#) :: OLE # 2");
            }
            catch (Exception ex) {
                MessageBox.Show("Невозможно сохранить изменения в базе данных LWP10-DB-OLE-Special.accdb (" + ex.Message + ")!", "Работа с базами данных (C#) :: OLE # 2");
            }
        }

        private void B_XML_Search_Click(object sender, EventArgs e) {
            SFD_XML.ShowDialog();
            TB_XML_Path.Text = SFD_XML.FileName;
        }

        private void B_XML_Create_Click(object sender, EventArgs e) {
            XmlWriterSettings SettingsXML = new XmlWriterSettings();
            SettingsXML.Indent = true; // Включаемотступдляэлементов XML-документа
            SettingsXML.IndentChars = "    "; // Задаёмотступ (пробелами)
            SettingsXML.NewLineChars = "\n"; // Задаём переход на новую строку
                                             // Нужно ли опустить строку декларации формата XML документа
                                             // Речь идёт о строке вида "<?xml version="1.0" encoding="utf-8"?>"
            SettingsXML.OmitXmlDeclaration = false;

            using (XmlWriter OutputXML = XmlWriter.Create(SFD_XML.FileName, SettingsXML)) {
                // Создалиоткрывающийсятег
                OutputXML.WriteStartElement("XML-Test");
                // Добавляематрибутдля XML-Test
                OutputXML.WriteAttributeString("Count_Parameters", "4");
                // Создаемэлемент<имя>элемент</имя>
                OutputXML.WriteElementString("Question", "Answer");
                Random R = new Random();
                OutputXML.WriteElementString("A", R.Next(0, 1000).ToString());
                OutputXML.WriteElementString("B", SQL_OLE);
                OutputXML.WriteElementString("C", TB_XML_Path.Text);
                OutputXML.WriteStartElement("Names");
                OutputXML.WriteStartElement("Name");
                OutputXML.WriteAttributeString("Type", "Male");
                OutputXML.WriteString("John");
                OutputXML.WriteEndElement();
                OutputXML.WriteStartElement("Name");
                OutputXML.WriteAttributeString("Type", "Male");
                OutputXML.WriteString("Teo");
                OutputXML.WriteEndElement();
                OutputXML.WriteStartElement("Name");
                OutputXML.WriteAttributeString("Type", "Famale");
                OutputXML.WriteString("Miana");
                OutputXML.WriteEndElement();
                // Закрываем XML-Test
                OutputXML.WriteEndElement();
                // Сбрасываембуфферизированныеданные
                OutputXML.Flush();
                // Закрываем фаил, с которым связан output
                OutputXML.Close();
                MessageBox.Show("Документ " + SFD_XML.FileName + " успешно создан!", "Работа с базами данных (C#) :: XML");
            }
        }

        private void B_XML_Read_Click(object sender, EventArgs e) {
            String S = null;
            LB_XML.Items.Clear();
            // Создаёмэкземпляркласса
            XmlDocument InputXML = new XmlDocument();
            // Загружаем XML-документизфайла
            InputXML.Load(SFD_XML.FileName);

            // Загружаем XML-документ из строки
            // InputXML.LoadXML(Path);

            // Получаем всех детей корневого элемента
            // InputXML.DocumentElement - корневой элемент
            foreach (XmlNode Table in InputXML.DocumentElement.ChildNodes) {
                // Перебираемвсеатрибутыэлемента
                foreach (XmlAttribute A in Table.Attributes) {
                    // A.Name - имя текущего атрибута
                    // A.Value - значение текущего атрибута
                    S = A.Name + ": " + A.Value;
                }
                // Перебираемвсехдетейтекущегоузла
                foreach (XmlNode CN in Table.ChildNodes) {
                }
                // Получаем текст хранящийся в текущем узле
                S = S + Table.InnerText + "\n\t";
            }
            MessageBox.Show("Значения аттрибутов для элеметов и узлов файла " + SFD_XML.FileName + ":\n\n\t" + S + "\nЗначения получены автоматическим перебором!", "Работа с базами данных (C#) :: XML");
            // Вытаскиваем значения "руками"
            XmlNodeList XMLTestAttributes = InputXML.SelectNodes("/XML-Test[@Count_Parameters='4']");

            foreach (XmlNode XN in XMLTestAttributes) {
                LB_XML.Items.Add(XN.InnerText + " -- все значения"); // В ListBox получаем значения всех узлов
            }
            XmlNodeList Names = InputXML.SelectNodes("/XML-Test/Names/Name[@Type='Male']");

            foreach (XmlNode XN in Names) {
                LB_XML.Items.Add(XN.InnerText + " -- одно мужское имя"); // В ListBox получаем только два мужских имени по отдельности
            }
            XmlNode Question = InputXML.DocumentElement.SelectSingleNode("Question");
            LB_XML.Items.Add(Question.InnerXml);
            XmlNode ANode = InputXML.DocumentElement.SelectSingleNode("A");
            LB_XML.Items.Add(ANode.InnerText);
            XmlNode BNode = InputXML.DocumentElement.SelectSingleNode("B");
            LB_XML.Items.Add(BNode.InnerText);
            XmlNode CNode = InputXML.DocumentElement.SelectSingleNode("C");
            LB_XML.Items.Add(CNode.InnerText);
            XmlNode NamesNode = InputXML.DocumentElement.SelectSingleNode("Names");
            LB_XML.Items.Add(NamesNode.InnerText + " -- всеимена"); // В Listbox получаемвсеимена
        }

        private void B_XML_DB_Click(object sender, EventArgs e) {
            LWP10Wallpapper DBWallpapper = new LWP10Wallpapper();
            DBWallpapper.ShowDialog();
        }
    }
}
