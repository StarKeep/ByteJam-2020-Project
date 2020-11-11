using ByteJamObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace US_Codestitution
{
	public partial class Form1 : Form
	{
	 	public int correctScore = 0;
		public int wrongScore = 0;

		Timer gameTimer = new Timer();

		/*public void InitializeData()
		{
			try
			{
				// Create a new adapter and give it a query to fetch sales order, contact,
				// address, and product information for sales in the year 2002. Point connection
				// information to the configuration setting "AdventureWorks".
				string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BytejamDatabase;Integrated Security=True";
				SqlConnection connection = new SqlConnection( connectionString );

				InitializeVoters( connection );
				InitializeBallots( connection );
				InitializeLicenses( connection );
				InitializeSocials( connection );
			}
			catch ( SqlException ex )
			{
				Console.WriteLine( "SQL exception occurred: " + ex.Message );
			}
		}
		private void InitializeVoters( SqlConnection connection )
		{
			string commandText = "select * from Voters";
			SqlCommand command = new SqlCommand( commandText, connection );

			SqlDataAdapter da = new SqlDataAdapter( command );
			da.SelectCommand = command;

			voters = new List<Voter>();

			DataTable dt = new DataTable();

			da.Fill( dt );

			SortedDictionary<int, Voter> votersSorted = new SortedDictionary<int, Voter>();

			foreach ( DataRow row in dt.Rows )
			{
				if ( int.TryParse( row.Field<string>( "CID" ), out int rowIndex ) )
					if ( rowIndex > -1 )
						votersSorted.Add( rowIndex, new Voter( row, rowIndex ) );
			}

			foreach ( Voter voter in votersSorted.Values )
				voters.Add( voter );
		}
		private void InitializeBallots( SqlConnection connection )
		{
			string commandText = "select * from Ballots";
			SqlCommand command = new SqlCommand( commandText, connection );

			SqlDataAdapter da = new SqlDataAdapter( command );
			da.SelectCommand = command;

			ballots = new List<Ballot>();

			DataTable dt = new DataTable();

			da.Fill( dt );

			foreach ( DataRow row in dt.Rows )
				ballots.Add( new Ballot( row ) );
		}
		private void InitializeLicenses( SqlConnection connection )
		{
			string commandText = "select * from Licenses";
			SqlCommand command = new SqlCommand( commandText, connection );

			SqlDataAdapter da = new SqlDataAdapter( command );
			da.SelectCommand = command;

			driversLicenses = new List<DriversLicense>();

			DataTable dt = new DataTable();

			da.Fill( dt );

            //help i have know idea what this trash is
            SortedDictionary<int, DriversLicense> driversLicensesSorted = new SortedDictionary<int, DriversLicense>();

            foreach (DataRow row in dt.Rows)
            {
                if (int.TryParse(row.Field<string>("DID"), out int rowIndex))
                    if (rowIndex > -1)
                        driversLicensesSorted.Add(rowIndex, new DriversLicense(row, rowIndex));
            }

            foreach (DriversLicense driversLicense in driversLicensesSorted.Values)
                driversLicenses.Add(driversLicense);

            *//*foreach (DataRow row in dt.Rows)
				driversLicenses.Add(new DriversLicense(row));*//*
		}
		private void InitializeSocials( SqlConnection connection )
		{
			string commandText = "select * from SocialSecurities";
			SqlCommand command = new SqlCommand( commandText, connection );

			SqlDataAdapter da = new SqlDataAdapter( command );
			da.SelectCommand = command;

			socials = new List<Social>();

			DataTable dt = new DataTable();

			da.Fill( dt );

			foreach ( DataRow row in dt.Rows )
				socials.Add( new Social( row ) );
		}*/


		public bool ReFill()
		{
			int index = RandomizationModule.random.Next(22);


			Ballot ballet = (Ballot)ballots[index].Clone(); 
			DriversLicense driversLicense = (DriversLicense)driversLicenses[index].Clone();
			Social social = (Social)socials[index].Clone();
			Voter voter = (Voter)voters[index].Clone();


			bool isCorrect = true;

			if ( isCorrect )
			{
				isCorrect = !ballet.Randomize( index );
			}
			if ( isCorrect )
			{
				isCorrect = !social.Randomize( index );
			}
			if ( isCorrect )
			{
				isCorrect = !driversLicense.Randomize( index );
			}
			if ( isCorrect )
			{
				isCorrect = !voter.Randomize( index );
			}

			FillLabels( ballet, driversLicense, social, voter );

			return isCorrect;
		}

		private void GetPoint( bool isCorrect, bool userChoice )
		{
			if (userChoice == isCorrect)
			{
				correctScore += 1;
				ScoreCount1.Text = correctScore.ToString();
				timerBar.Value = Math.Min(timerBar.Maximum, timerBar.Value + 100);

				if (correctScore >= 30)
				{
					MessageBox.Show( "You met your quota!", "Winner Is You!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
					timerBar.Value = 0;
				}
			}
			else
			{
				wrongScore += 1;
				ScoreCount2.Text = wrongScore.ToString();
				timerBar.Value = Math.Max(1, timerBar.Value - 200);
			}
		}

		private void FillLabels( Ballot ballet, DriversLicense driversLicense, Social social, Voter voter )
		{
			//Ballet
			FirstNameLable.Text = ballet.FirstName;
			LastNameLable.Text = ballet.LastName;
			CityLable.Text = ballet.City;
			ZipLable.Text = ballet.ZipCode;
			StateLable.Text = ballet.State;
			SSNLable.Text = ballet.SSID;
			AddressLable1.Text = ballet.AddressLine1;
			Address2Lable.Text = ballet.AddressLine2;
			InputPicture.Image = voter.Photo;

			//driver
			DLFirstNameLable.Text = driversLicense.FirstName;
			DLLastNameLable.Text = driversLicense.LastName;
			DLCityLable.Text = driversLicense.City;
			DLZipLable.Text = driversLicense.ZipCode;
			DLStateLable.Text = driversLicense.State;
			DLGenderLable.Text = driversLicense.Gender.ToString();
			DriversLicensePicture.Image = driversLicense.Photo;


			//need address line one and two here


			//SSN
			label1.Text = social.FullName;
			SSIDFirstNameLable.Text = social.FullName;
			SSIDNumberLable.Text = social.SSN;

			

		}

		public Form1()
		{
			InitializeComponent();
			timerBar.Maximum = 3000;
			timerBar.Value = 3000;

			gameTimer.Tick += (x1, x2) => { if ( timerBar.Value > 1 ) timerBar.Value--; else if ( timerBar.Value == 1 ) { timerBar.Value = 0; MessageBox.Show( "Game over!", "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Error ); } };
			gameTimer.Interval = 10;
			gameTimer.Start();
		}

		private void Form1_Load( object sender, EventArgs e )
		{
			InitializeData();
			ReFill();
		}
		
		private bool NotifyIfGameNotActive()
		{
			if (timerBar.Value == 0)
			{
				MessageBox.Show( "The game has not yet started, please press restart to begin.", "Game Not Started", MessageBoxButtons.OK, MessageBoxIcon.Information );
				return true;
			}
			return false;
		}

		private void YesVote_Click( object sender, EventArgs e )
		{
			if (!NotifyIfGameNotActive())
			GetPoint(ReFill(), true);
		}

        private void NoVote_Click(object sender, EventArgs e)
        {
			if (!NotifyIfGameNotActive())
			GetPoint(ReFill(), false);
		}

        private void reset_click(object sender, EventArgs e)
        {
			wrongScore = 0;
			correctScore = 0;
			ScoreCount1.Text = correctScore.ToString();
			ScoreCount2.Text = correctScore.ToString();
			ReFill();
			timerBar.Value = 3000;
		}

		private void YesVoteHover( object sender, EventArgs e )
		{
			YesVote.BackgroundImage = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\pics\\Approve_Button_Push.png" );
		}

		private void YesVoteLeave( object sender, EventArgs e )
		{
			YesVote.BackgroundImage = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\pics\\Approve_Button.png" );
		}

		private void NoVoteHover( object sender, EventArgs e )
		{
			NoVote.BackgroundImage = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\pics\\Deny_Button_Push.png" );
		}

		private void NoVoteLeave( object sender, EventArgs e )
		{
			NoVote.BackgroundImage = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\pics\\Deny_Button.png" );
		}

		private void Reset_Hover( object sender, EventArgs e )
		{
			button1.BackgroundImage = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\pics\\Reset_Button_Push2.png" );
		}

		private void Reset_Leave( object sender, EventArgs e )
		{
			button1.BackgroundImage = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\pics\\Reset_Button2.png" );
		}

		private void Mute_Hover( object sender, EventArgs e )
		{
			button2.BackgroundImage = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\pics\\Sound_Button_Push.png" );
		}

		private void Mute_Leave( object sender, EventArgs e )
		{
			button2.BackgroundImage = Image.FromFile( $"{Environment.GetFolderPath( Environment.SpecialFolder.ApplicationData )}\\ByteJam\\pics\\Sound_Button.png" );
		}
	}
}
