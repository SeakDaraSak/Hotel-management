using BookingLib;

namespace WinFormBookingClient
{
    public partial class Form1 : Form
    {
        private BindingSource bs = new();
        public Form1()
        {
            InitializeComponent();
            DataGridView.CheckForIllegalCrossThreadCalls = false;
            bs.DataSource = new List<BookingResponse>();
            dgvProducts.DataSource = bs;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            btnRefresh.Click += DoClickRefresh;

            btnCreateSubmit.Click += DoClickCreateSubmit;

            bs.PositionChanged += DoBookingPositionChanged;

            btnUpdateSubmit.Click += DoClickUpdateSubmit;

            btnDelete.Click += DoClickDelete;

            btnCreateClear.Click += DoClickCreateClear;
        }

        private void DoClickCreateClear(object? sender, EventArgs e)
        {
            txtCreatefullname.Clear();
            txtCreategender.Clear();
            textcreatephone.Clear();
            textcreateroomno.Clear();
            textcreateroomtype.Clear();
            textcreatedate.Clear();
        }

        private async void DoClickDelete(object? sender, EventArgs e)
        {
            if (bs.Current == null) return;
            if (bs.Current is not BookingResponse bd) return;
            string endpoint = $"api/Bookings/{bd.Id}";
            var result = await Program.RestClient.DeleteAsync<Result<string?>>(endpoint);
            if (result!.Succeded && bd.Id == result!.Data)
            {
                bs.RemoveCurrent();
                bs.ResetBindings(false);
            }
            MessageBox.Show(result!.Message);
        }

        private async void DoClickUpdateSubmit(object? sender, EventArgs e)
        {
            string endpoint = "api/Bookings";
            var req = new BookingUpdateReq()
            {
                fullName= textupdatefullname.Text,
                Gender= textupdategender.Text,
                Phone= textupdatephone.Text,
                RoomNo= textupdateroomno.Text,
                RoomType= textupdateroomtype.Text,
                Date= textupdatedate.Text,

            };
            var result = await Program.RestClient.PutAsync<BookingUpdateReq, Result<string?>>(endpoint, req);
            Task task = Task.Run(async () =>
            {
                if (result!.Succeded)
                {
                    endpoint = $"api/Bookings/{result!.Data!}";
                    var foundResult = await Program.RestClient.GetAsync<Result<BookingResponse?>>(endpoint);
                    if (foundResult!.Succeded && foundResult.Data != null)
                    {
                        var found = (bs.DataSource as List<BookingResponse>)?.FirstOrDefault(b => b.Id == foundResult.Data.Id);
                        if (found != null)
                        {
                            found.fullName = foundResult.Data.fullName;
                            bs.ResetBindings(false);
                        }
                    }
                }
            });
            MessageBox.Show(result!.Message);
            task.Wait();
        }

        private void DoBookingPositionChanged(object? sender, EventArgs e)
        {
            if (bs.Current == null)
            {
                textupdatefullname.Clear();
                textupdategender.Clear();
                textupdatephone.Clear();
                textupdateroomno.Clear();
                textupdateroomtype.Clear();
                textupdatedate.Clear();
            }
            else
            {
                if (bs.Current is BookingResponse bk)
                {
                    textupdatefullname.Text = bk.fullName.ToString();
                    textupdategender.Text = bk.fullName;
                    textupdatephone.Text = bk.Phone;
                    textcreateroomno.Text = bk.RoomNo;
                    textcreateroomtype.Text=bk.RoomType;
                    textupdatedate.Text = bk.Date;
                }
            }
        }

        private async void DoClickCreateSubmit(object? sender, EventArgs e)
        {
            string endpoint = "api/Bookings";
            var req = new BookingCreateReq()
            {
                fullName = txtCreatefullname.Text,
                Gender = txtCreategender.Text,
                Phone=textcreatephone.Text,
                RoomNo=textcreateroomno.Text,
                RoomType=textcreateroomtype.Text,
                Date=textupdatedate.Text,
            };
            var result = await Program.RestClient.PostAsync<BookingCreateReq, Result<string?>>(endpoint, req);
            Task task = Task.Run(async () =>
            {
                if (result!.Succeded)
                {
                    endpoint = $"api/Bookings/{result!.Data}";
                    var foundResult = await Program.RestClient.GetAsync<Result<BookingResponse?>>(endpoint);
                    if (foundResult!.Succeded && foundResult.Data != null)
                    {
                        (bs.DataSource as List<BookingResponse>)?.Add(foundResult.Data);
                        bs.ResetBindings(false);
                    }
                }
            });
            MessageBox.Show(result!.Message);
        }

        private async void DoClickRefresh(object? sender, EventArgs e)
        {
            string endpoint = "api/Bookings";
            var result = await Program.RestClient.GetAsync<Result<List<BookingResponse>>>(endpoint);
            if (result!.Succeded == true)
            {
                bs.DataSource = result.Data;
                bs.ResetBindings(false);
            }
        }

    }
}