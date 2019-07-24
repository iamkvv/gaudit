using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Gaudit.DataSet1TableAdapters;

namespace Gaudit
{
    public partial class GilFondObjects : Form
    {
        //DataSet1 ds;
        GilFondObjectTableAdapter gfObjectsAdapter;
        PorchGilFondОbjectsTableAdapter porchAdapter;
        PomeschGilFondОbsTableAdapter pomeschAdapter;
        NeGiloePomeschTableAdapter neGiloeAdapter;

        private int currObjID = 0; //Текущий дом 
        private int currPorchID = 0;//Текущий подъезд

        public GilFondObjects()
        {
            InitializeComponent();

           // ds = new DataSet1();

            gfObjectsAdapter = new GilFondObjectTableAdapter();
            porchAdapter = new PorchGilFondОbjectsTableAdapter();
            pomeschAdapter = new PomeschGilFondОbsTableAdapter();
            neGiloeAdapter = new NeGiloePomeschTableAdapter();
        }

        private void btnGetSave_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] cliparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/house/list");

                if (cliparr == null) return;

                string[] data = cliparr.Where(o => !o.Contains("Информация об объекте") && !o.Contains("ОДПУ")).ToArray();

                int skip = 0;
                string[] z;

                while ((z = data.Skip(skip).Take(12).ToArray()).Count() != 0)
                {
                    skip += 12;
                    cnt++;

                    gfObjectsAdapter.Insert(
                        ActiveAudit.ID,
                        ActiveAudit.ID_Company,
                        z[0], //адрес
                        z[1].Split('\t')[1], //год постройки
                        z[2].Split('\t')[1], //год ввода
                        z[3].Split('\t')[1], //кадастр
                        z[4].Split('\t')[1], //этажей
                        z[5].Split('\t')[1], //состояние
                        z[6].Split('\t')[1], //износ
                        z[7].Split('\t')[1], //кол-во ЛС
                        z[8].Split('\t')[1], //Кол_во помещений
                        z[9].Split('\t')[1],//  Тип
                        z[10].Split('\t')[1],//Общая площадь
                        z[11].Split('\t')[1]); //Общая полощ жил пом

                }
                grdGFObjects.DataSource = gfObjectsAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Clipboard.Clear();
                Cursor.Current = Cursors.Default;

                ActiveAudit.CheckGrid(grdGFObjects);
            }
        }

        private void GilFondObjects_Load(object sender, EventArgs e)
        {
            try
            {
                grdGFObjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                grdPorch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                grdPomesch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                grdNegil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                // gfObjectsAdapter.FillByActiveAudit(ds.GilFondObject, ActiveAudit.ID, ActiveAudit.ID_Company);
                grdGFObjects.DataSource = gfObjectsAdapter.GetDataByActiveAudit(ActiveAudit.ID, ActiveAudit.ID_Company);
                //  porchAdapter.FillBySelectObject(ds.PorchGilFondОbjects, this.currObjID);
                grdPorch.DataSource = porchAdapter.GetDataBySelectObject(this.currPorchID);
                // pomeschAdapter.FillBySelectedPorch(ds.PomeschGilFondОbs, currPorchID);
                grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(this.currPorchID);
                grdNegil.DataSource = neGiloeAdapter.GetDataByActiveObject(this.currObjID);

                ActiveAudit.CheckGrid(grdGFObjects);
                ActiveAudit.CheckGrid(grdPorch);
                ActiveAudit.CheckGrid(grdPomesch);
                ActiveAudit.CheckGrid(grdNegil);

                grdGFObjects.Columns[0].Visible = false;
                grdGFObjects.Columns[1].Visible = false;
                grdGFObjects.Columns[2].Visible = false;

                grdGFObjects.Columns[3].Width = grdGFObjects.Width / 12;
                grdGFObjects.Columns[4].Width = grdGFObjects.Width / 12;
                grdGFObjects.Columns[5].Width = grdGFObjects.Width / 11;
                grdGFObjects.Columns[6].Width = grdGFObjects.Width / 11;
                grdGFObjects.Columns[7].Width = grdGFObjects.Width / 11;

                grdGFObjects.Columns[8].Width = grdGFObjects.Width / 12;
                grdGFObjects.Columns[9].Width = grdGFObjects.Width / 12;
                grdGFObjects.Columns[10].Width = grdGFObjects.Width / 11;
                grdGFObjects.Columns[11].Width = grdGFObjects.Width / 11;
                grdGFObjects.Columns[12].Width = grdGFObjects.Width / 11;
                grdGFObjects.Columns[13].Width = grdGFObjects.Width / 11;

                grdPorch.Columns[0].Visible = false;
                grdPorch.Columns[1].Visible = false;
                grdPorch.Columns[2].Visible = false;
                grdPorch.Columns[3].Visible = false;

                grdPorch.Columns[4].Width = grdPorch.Width / 5;
                grdPorch.Columns[5].Width = grdPorch.Width / 4;
                grdPorch.Columns[6].Width = grdPorch.Width / 4;
                grdPorch.Columns[7].Width = grdPorch.Width / 4;


                grdPomesch.Columns[0].Visible = false;
                grdPomesch.Columns[1].Visible = false;
                grdPomesch.Columns[2].Visible = false;
                grdPomesch.Columns[3].Visible = false;

                grdPomesch.Columns[4].Width = grdPomesch.Width / 10;
                grdPomesch.Columns[5].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[6].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[7].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[8].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[9].Width = grdPomesch.Width / 7;
                grdPomesch.Columns[10].Width = grdPomesch.Width / 7;


                grdNegil.Columns[0].Visible = false;
                grdNegil.Columns[1].Visible = false;
                grdNegil.Columns[2].Visible = false;
                grdNegil.Columns[3].Visible = false;

                grdNegil.Columns[4].Width = grdNegil.Width / 6;
                grdNegil.Columns[5].Width = grdNegil.Width / 6;
                grdNegil.Columns[6].Width = grdNegil.Width / 6;
                grdNegil.Columns[7].Width = grdNegil.Width / 6;
                grdNegil.Columns[8].Width = grdNegil.Width / 6;
                grdNegil.Columns[9].Width = grdNegil.Width / 6;

                grdGFObjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdPorch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdPomesch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdNegil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        private void btnGetPorch_Click(object sender, EventArgs e)
        {//данные подъездов
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] clparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/house/card?houseCardGuid");

                if (clparr == null) return;

                int skip = 0;
                string[] strarr;

                if (clparr.Count() % 4 != 0)
                {
                    MessageBox.Show("Данные подъездов скопированы некорректно.");
                    return;
                }

                while ((strarr = clparr.Skip(skip).Take(4).ToArray()).Count() != 0)
                {
                    skip += 4;
                    porchAdapter.Insert(
                        this.currObjID,
                        ActiveAudit.ID_Company,
                        ActiveAudit.ID,
                        strarr[0].Split(' ')[strarr[0].Split(' ').Length - 1], //Номер
                        strarr[1].Split(' ')[strarr[1].Split(' ').Length - 1], //Количество ЛС
                        strarr[2].Split(' ')[strarr[2].Split(' ').Length - 1], // Этажность
                        strarr[3].Split(' ')[strarr[3].Split(' ').Length - 1]  //Год постройки
                        );
                }

                grdPorch.DataSource = porchAdapter.GetDataBySelectObject(this.currObjID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Clipboard.Clear();
                Cursor.Current = Cursors.Default;

                ActiveAudit.CheckGrid(grdPorch);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            grdPorch.DataSource = porchAdapter.GetDataBySelectObject(this.currObjID);
            grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(this.currPorchID);

            ActiveAudit.CheckGrid(grdPorch);
            ActiveAudit.CheckGrid(grdPomesch);

        }

        private void grdGFObjects_SelectionChanged(object sender, EventArgs e)
        {
            if (grdGFObjects.CurrentRow != null)
            {
                this.currObjID = (int)grdGFObjects.CurrentRow.Cells[0].Value;
                lblCurrObjID.Text = this.currObjID.ToString();

                DataTable dt = porchAdapter.GetDataBySelectObject(this.currObjID);

                grdPorch.DataSource = dt; //   porchAdapter.GetDataBySelectObject(this.currObjID);

                if(grdPorch.CurrentRow == null)
                {
                    this.currPorchID = 0;
                }
                else
                {
                    this.currPorchID = (int)grdPorch.CurrentRow.Cells[0].Value;
                }

                
                grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(this.currPorchID);

                grdNegil.DataSource = neGiloeAdapter.GetDataByActiveObject(this.currObjID);

                ActiveAudit.CheckGrid(grdPorch);
                ActiveAudit.CheckGrid(grdNegil);
            }
        }

        private void grdPorch_SelectionChanged(object sender, EventArgs e)
        {
            if (grdPorch.CurrentRow != null)
            {
                this.currPorchID = (int)grdPorch.CurrentRow.Cells[0].Value;
                lblCurrPorch.Text = this.currPorchID.ToString();

                grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(this.currPorchID);
                ActiveAudit.CheckGrid(grdPomesch);
            }
            else
            {
                Console.WriteLine(this.currPorchID);
            }
        }

        private void btnGetPomesch_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string[] clparr = ActiveAudit.GetClipBoard("//my.dom.gosuslugi.ru/organization-cabinet/#!/house/card?");
                if (clparr == null) return;

                int selPorchId = (int)grdPorch.CurrentRow.Cells[0].Value; //временно на всякий случай

                string[] pdata = clparr.Where(s => !s.Contains("ПУ")).ToArray();

                if (pdata.Count() % 7 != 0)
                {
                    MessageBox.Show("Данные помещений скопированы некорректно.");
                    return;
                }

                int skip = 0;
                string[] arr;

                while ((arr = pdata.Skip(skip).Take(7).ToArray()).Count() != 0)
                {
                    skip += 7;

                    pomeschAdapter.Insert(
                        selPorchId,
                        ActiveAudit.ID,
                        ActiveAudit.ID_Company,
                        arr[0].Split('№')[arr[0].Split('№').Length - 1], //Номер
                        arr[1].Split('\t')[arr[1].Split('\t').Length - 1], //категория
                        arr[2].Split('\t')[arr[2].Split('\t').Length - 1].Split(' ')[0], //Общая пл-дь
                        arr[3].Split('\t')[arr[3].Split('\t').Length - 1].Split(' ')[0], //жилая пл-дь
                        arr[4].Split('\t')[arr[1].Split('\t').Length - 1],//Кадастр
                        arr[5].Split(':')[1], //хар-ка
                        arr[6].Split('\t')[1]
                        );
                }

                grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(selPorchId);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Clipboard.Clear();
                Cursor.Current = Cursors.Default;
                ActiveAudit.CheckGrid(grdPomesch);
            }
        }

        private void btnDeletePorch_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Удалить данные подъездов?",
                                    "Подъезды",
                                     MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                porchAdapter.DeleteSelectedPorch(this.currPorchID);

                if (grdPorch.CurrentRow != null)
                {
                    this.currPorchID = (int)grdPorch.CurrentRow.Cells[0].Value;
                    lblCurrPorch.Text = this.currPorchID.ToString();

                    grdPorch.DataSource = porchAdapter.GetDataBySelectObject(this.currObjID);

                    if (grdPorch.RowCount == 0)
                    {
                        this.currPorchID = 0; //чтобы обнулить помещения
                    }

                    grdPomesch.DataSource = pomeschAdapter.GetDataBySelectedPorch(this.currPorchID);

                    ActiveAudit.CheckGrid(grdPorch);
                    ActiveAudit.CheckGrid(grdPomesch);
                }
            }
        }

        private void btnNegilAdd_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string[] clparr = ActiveAudit.GetClipBoard("nonResidential=yes");
                if (clparr == null) return;
                if (clparr.Count() % 7 != 0)
                {
                    MessageBox.Show("Данные нежилых помещений скопированы некорректно.");
                    return;
                }

                int skip = 0;
                string[] arr;

                while ((arr = clparr.Skip(skip).Take(7).ToArray()).Count() != 0)
                {
                    skip += 7;

                    neGiloeAdapter.Insert(
                        this.currObjID,
                        ActiveAudit.ID,
                        ActiveAudit.ID_Company,
                        arr[0],
                        arr[1].Split('\t')[1],
                        arr[2].Split('\t')[1],
                        arr[3].Split('\t')[1],
                        arr[4].Split('\t')[1],
                        arr[6].Split('\t')[1]
                        );
                }

                grdNegil.DataSource = neGiloeAdapter.GetDataByActiveObject(this.currObjID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Clipboard.Clear();

                ActiveAudit.CheckGrid(grdNegil);
            }
        }

        private void btnNegilDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить данные нежилых помещений?",
                                   "Нежилые помещения",
                                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                neGiloeAdapter.DeleteByActiveObject(this.currObjID);
                grdNegil.DataSource = neGiloeAdapter.GetDataByActiveObject(this.currObjID);
                
                ActiveAudit.CheckGrid(grdNegil);
            }
        }
    }
}
