using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PLWPF
{
	/// <summary>
	/// Interaction logic for Tester.xaml
	/// </summary>
	public partial class Tester : Window
	{
		BL.IBL bl = new BL.Bl_imp();

		public Tester()
		{
			InitializeComponent();
			try
			{
				genderTesterComboBox.Items.Add(BE.Gender.Male);
				genderTesterComboBox.Items.Add(BE.Gender.Female);
				
				genderTesterComboBoxToUpdate.Items.Add(BE.Gender.Male);
				genderTesterComboBoxToUpdate.Items.Add(BE.Gender.Female);
				

				carTypeSpcializesComboBox.Items.Add(BE.CarType.HeavyTruck);
				carTypeSpcializesComboBox.Items.Add(BE.CarType.MediumTruck);
				carTypeSpcializesComboBox.Items.Add(BE.CarType.PrivateVehicle);
				carTypeSpcializesComboBox.Items.Add(BE.CarType.TwoWheeledVehicle);
				carTypeSpcializesComboBoxToUpdate.Items.Add(BE.CarType.HeavyTruck);
				carTypeSpcializesComboBoxToUpdate.Items.Add(BE.CarType.MediumTruck);
				carTypeSpcializesComboBoxToUpdate.Items.Add(BE.CarType.PrivateVehicle);
				carTypeSpcializesComboBoxToUpdate.Items.Add(BE.CarType.TwoWheeledVehicle);

			
				bool[][] temp = new bool[7][];
				for (int i = 0; i < 7; i++)
				{
					temp[i] = new bool[5];
				}
				bl.addTester(new BE.Tester("205829500", "A", "h", new DateTime(1000, 11, 07), new BE.Gender() { }, 222, new BE.Address() { street = "Yoseftal", buildingNumber = 48 / 1, city = "Zefat" }, 333, 555, new BE.CarType(), temp, 444));
				bl.addTester(new BE.Tester("062839360", "a", "b", new DateTime(1960, 1, 1), new BE.Gender(), 222, new BE.Address(), 333, 555, new BE.CarType(), temp, 444));
				bl.addTester(new BE.Tester("066416611", "a", "b", new DateTime(1960, 1, 1), new BE.Gender(), 222, new BE.Address(), 333, 555, new BE.CarType(), temp, 444));

				bl.addTrainee(new BE.Trainee("330886284", new DateTime(2018, 12, 29), "a", "b", new BE.Gender(), 222, new BE.Address() { street = "a", buildingNumber = 99 / 1, city = "m" }, new DateTime(1960, 1, 1), new BE.CarType(), new BE.GearboxType(), "sss", "eeee", 888));
				bl.addTrainee(new BE.Trainee("217984749", new DateTime(1960, 1, 1), "a", "b", new BE.Gender(), 222, new BE.Address() { street = "a", buildingNumber = 99 / 1, city = "m" }, new DateTime(1960, 1, 1), new BE.CarType(), new BE.GearboxType(), "sss", "eeee", 444));
				bl.addTrainee(new BE.Trainee("335746962", new DateTime(1960, 1, 1), "a", "b", new BE.Gender(), 222, new BE.Address() { street = "a", buildingNumber = 99 / 1, city = "m" }, new DateTime(1960, 1, 1), new BE.CarType(), new BE.GearboxType(), "sss", "eeee", 444));

				bl.addTest(new BE.Test(BE.Configuration.RunningIDNumber, "205829500", "330886284", new DateTime(1960, 1, 1), new DateTime(1960, 1, 1), new BE.Address(), false, true, false, false, false, "comment"));
				bl.addTest(new BE.Test(BE.Configuration.RunningIDNumber, "062839360", "217984749", new DateTime(1961, 1, 2), new DateTime(1969, 1, 1), new BE.Address(), false, false, false, false, true, "comment"));
				bl.addTest(new BE.Test(BE.Configuration.RunningIDNumber, "066416611", "335746962", new DateTime(1962, 1, 3), new DateTime(1963, 1, 8), new BE.Address(), false, false, false, false, true, "comment"));
				testerListBox.DataContext = bl.getTestersList();

			




			}
			catch (Exception e)
			{

				MessageBox.Show(e.Message);
			}

		}
		private void AddTesterButton_Click(object sender, RoutedEventArgs e)
		{

			bool[][] scheduleAdd = new bool[7][];
			for (int i = 0; i < 7; i++)
			{
				scheduleAdd[i] = new bool[5];
			}
			scheduleAdd[0][0] = c01Add.IsChecked.Value;
			scheduleAdd[1][0] = c11Add.IsChecked.Value;
			scheduleAdd[2][0] = c21Add.IsChecked.Value;
			scheduleAdd[3][0] = c31Add.IsChecked.Value;
			scheduleAdd[4][0] = c41Add.IsChecked.Value;
			scheduleAdd[5][0] = c51Add.IsChecked.Value;
			scheduleAdd[6][0] = c61Add.IsChecked.Value;
			scheduleAdd[0][1] = c02Add.IsChecked.Value;
			scheduleAdd[1][1] = c12Add.IsChecked.Value;
			scheduleAdd[2][1] = c22Add.IsChecked.Value;
			scheduleAdd[3][1] = c32Add.IsChecked.Value;
			scheduleAdd[4][1] = c42Add.IsChecked.Value;
			scheduleAdd[5][1] = c52Add.IsChecked.Value;
			scheduleAdd[6][1] = c62Add.IsChecked.Value;
			scheduleAdd[0][2] = c03Add.IsChecked.Value;
			scheduleAdd[1][2] = c13Add.IsChecked.Value;
			scheduleAdd[2][2] = c23Add.IsChecked.Value;
			scheduleAdd[3][2] = c33Add.IsChecked.Value;
			scheduleAdd[4][2] = c43Add.IsChecked.Value;
			scheduleAdd[5][2] = c53Add.IsChecked.Value;
			scheduleAdd[6][2] = c63Add.IsChecked.Value;
			scheduleAdd[0][3] = c04Add.IsChecked.Value;
			scheduleAdd[1][3] = c14Add.IsChecked.Value;
			scheduleAdd[2][3] = c24Add.IsChecked.Value;
			scheduleAdd[3][3] = c34Add.IsChecked.Value;
			scheduleAdd[4][3] = c44Add.IsChecked.Value;
			scheduleAdd[5][3] = c54Add.IsChecked.Value;
			scheduleAdd[6][3] = c64Add.IsChecked.Value;
			scheduleAdd[0][4] = c05Add.IsChecked.Value;
			scheduleAdd[1][4] = c15Add.IsChecked.Value;
			scheduleAdd[2][4] = c25Add.IsChecked.Value;
			scheduleAdd[3][4] = c35Add.IsChecked.Value;
			scheduleAdd[4][4] = c45Add.IsChecked.Value;
			scheduleAdd[5][4] = c55Add.IsChecked.Value;
			scheduleAdd[6][4] = c65Add.IsChecked.Value;
			DateTime? d = dateOfBirthTester.SelectedDate;
			try
			{
				bl.addTester(new BE.Tester(Convert.ToString(idBox.Text), lastNameBox.Text, firstNameBox.Text, d.Value, new BE.Gender(), Convert.ToInt32(phoneNumberBox.Text), new BE.Address() { street = streetBox.Text, buildingNumber = Convert.ToInt32(buildingNumberBox.Text), city = cityBox.Text }, Convert.ToInt32(yearsOfExperienceBox.Text), Convert.ToInt32(maxWeeklyTestsBox.Text), new BE.CarType(), scheduleAdd, Convert.ToDouble(maxDistanceExamBox.Text)));
				MessageBox.Show("Tester succesfully added");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			testerListBox.DataContext = bl.getTestersList();


		}
		private void DelleteTesterButton_Click(object sender, RoutedEventArgs e)
		{
			int temp = Convert.ToInt32(testerIdToDellete.Text);
			foreach (BE.Tester item in bl.getTestersList())
			{
				if (temp.CompareTo(item.Id) == 0)
				{
					bl.delleteTester(item);
					testerListBox.DataContext = bl.getTestersList();

					MessageBox.Show("Tester succesfully delleted");
					foreach (BE.Tester x in bl.getTestersList())
					{
						MessageBox.Show(x.ToString()
);
					}
					return;
				}
			}

		}
		private void UpdateTesterButton_Click(object sender, RoutedEventArgs e)
		{
			bool[][] schedule = new bool[7][];
			for (int i = 0; i < 7; i++)
			{
				schedule[i] = new bool[5];
			}
			schedule[0][0] = c01.IsChecked.Value;
			schedule[1][0] = c11.IsChecked.Value;
			schedule[2][0] = c21.IsChecked.Value;
			schedule[3][0] = c31.IsChecked.Value;
			schedule[4][0] = c41.IsChecked.Value;
			schedule[5][0] = c51.IsChecked.Value;
			schedule[6][0] = c61.IsChecked.Value;
			schedule[0][1] = c02.IsChecked.Value;
			schedule[1][1] = c12.IsChecked.Value;
			schedule[2][1] = c22.IsChecked.Value;
			schedule[3][1] = c32.IsChecked.Value;
			schedule[4][1] = c42.IsChecked.Value;
			schedule[5][1] = c52.IsChecked.Value;
			schedule[6][1] = c62.IsChecked.Value;
			schedule[0][2] = c03.IsChecked.Value;
			schedule[1][2] = c13.IsChecked.Value;
			schedule[2][2] = c23.IsChecked.Value;
			schedule[3][2] = c33.IsChecked.Value;
			schedule[4][2] = c43.IsChecked.Value;
			schedule[5][2] = c53.IsChecked.Value;
			schedule[6][2] = c63.IsChecked.Value;
			schedule[0][3] = c04.IsChecked.Value;
			schedule[1][3] = c14.IsChecked.Value;
			schedule[2][3] = c24.IsChecked.Value;
			schedule[3][3] = c34.IsChecked.Value;
			schedule[4][3] = c44.IsChecked.Value;
			schedule[5][3] = c54.IsChecked.Value;
			schedule[6][3] = c64.IsChecked.Value;
			schedule[0][4] = c05.IsChecked.Value;
			schedule[1][4] = c15.IsChecked.Value;
			schedule[2][4] = c25.IsChecked.Value;
			schedule[3][4] = c35.IsChecked.Value;
			schedule[4][4] = c45.IsChecked.Value;
			schedule[5][4] = c55.IsChecked.Value;
			schedule[6][4] = c65.IsChecked.Value;

			BE.CarType c = new BE.CarType();
			BE.Gender g = new BE.Gender();
			if (Convert.ToString(BE.CarType.HeavyTruck) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.HeavyTruck;
			}
			if (Convert.ToString(BE.CarType.MediumTruck) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.MediumTruck;
			}
			if (Convert.ToString(BE.CarType.PrivateVehicle) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.PrivateVehicle;
			}
			if (Convert.ToString(BE.CarType.TwoWheeledVehicle) == carTypeSpcializesComboBoxToUpdate.Text)
			{
				c = BE.CarType.TwoWheeledVehicle;
			}
			if (Convert.ToString(BE.Gender.Female) == genderTesterComboBoxToUpdate.Text)
			{
				g = BE.Gender.Female;
			}
			if (Convert.ToString(BE.Gender.Male) == genderTesterComboBoxToUpdate.Text)
			{
				g = BE.Gender.Male;
			}
			BE.Address a = new BE.Address();
			a.street = streetToUpdate.Text;
			a.buildingNumber = Convert.ToInt32(buildingNumberToUpdate.Text);
			a.city = cityToUpdate.Text;
			try
			{
				BE.Tester toUpdate = new BE.Tester(Convert.ToString(idBoxToUpdate.Text), lastNameBoxToUpdate.Text, firstNameBoxToUpdate.Text, Convert.ToDateTime(dateOfBirthTesterToUpdate.Text), g, Convert.ToInt32(phoneNumberBoxToUpdate.Text), a, Convert.ToInt32(yearsOfExperienceBoxToUpdate.Text), Convert.ToInt32(maxWeeklyTestsBoxToUpdate.Text), c, schedule, Convert.ToInt32(maxDistanceExamBoxToUpdate.Text));
				bl.updateExistTester(toUpdate);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			testerListBox.DataContext = bl.getTestersList();

		}
		
		private void RefreshTesterListButton_Click(object sender, RoutedEventArgs e)
		{
			//bool t = false;
			//for (int i = 0; i < testerListBox.Items.Count; i++)
			//{

			//	foreach (var item in bl.getTestersList())
			//	{
			//		if (testerListBox.Items.GetItemAt(i) == item)
			//		{
			//			t = true;
			//		}
			//	}
			//	if (!t)
			//	{
			//		testerListBox.Items.RemoveAt(i);
			//	}
			//}
			//foreach (BE.Tester item in bl.getTestersList())
			//{
			//	if (!testerListBox.Items.Contains(item))
			//	{
			//		testerListBox.Items.Add(item);
			//	}
			//}
		}
		

		
		private void ImporeTesterListButton_Click(object sender, RoutedEventArgs e)
		{
			testerListToUpdate.DataContext = bl.getTestersList();

			//foreach (BE.Tester item in bl.getTestersList())
			//{
			//	if (!testerListToUpdate.Items.Contains(item))
			//	{
			//		testerListToUpdate.Items.Add(item);
			//	}
			//}
		}
		

		private void testerListToUpdateSelectionChangedButton_Click(object sender, SelectionChangedEventArgs e)
		{

			//testerListToUpdate.IsDropDownOpen = false;
			BE.Tester w = testerListToUpdate.SelectedItem as BE.Tester;
			idBoxToUpdate.Text = Convert.ToString(w.Id);
			lastNameBoxToUpdate.Text = w.LastName;
			firstNameBoxToUpdate.Text = w.FirstName;
			dateOfBirthTesterToUpdate.Text = Convert.ToString(w.DateOfBirth);
			genderTesterComboBoxToUpdate.Text = (Convert.ToString(w.Gender));
			phoneNumberBoxToUpdate.Text = Convert.ToString(w.PhoneNumber);
			streetToUpdate.Text = Convert.ToString(w.Addresss.street);
			buildingNumberToUpdate.Text = Convert.ToString(w.Addresss.buildingNumber);
			cityToUpdate.Text = Convert.ToString(w.Addresss.city);
			yearsOfExperienceBoxToUpdate.Text = Convert.ToString(w.YearsOfExperience);
			maxWeeklyTestsBoxToUpdate.Text = Convert.ToString(w.MaximumNumberOfWeeklytestsPossible);
			carTypeSpcializesComboBoxToUpdate.Text = Convert.ToString(w.SpecializesInCarOfType);
			maxDistanceExamBoxToUpdate.Text = Convert.ToString(w.MaximumDistanceForExam);




			c01.IsChecked = w.WorkingDaysAndHours[0][0];
			c11.IsChecked = w.WorkingDaysAndHours[1][0];
			c21.IsChecked = w.WorkingDaysAndHours[2][0];
			c31.IsChecked = w.WorkingDaysAndHours[3][0];
			c41.IsChecked = w.WorkingDaysAndHours[4][0];
			c51.IsChecked = w.WorkingDaysAndHours[5][0];
			c61.IsChecked = w.WorkingDaysAndHours[6][0];

			c02.IsChecked = w.WorkingDaysAndHours[0][1];
			c12.IsChecked = w.WorkingDaysAndHours[1][1];
			c22.IsChecked = w.WorkingDaysAndHours[2][1];
			c32.IsChecked = w.WorkingDaysAndHours[3][1];
			c42.IsChecked = w.WorkingDaysAndHours[4][1];
			c52.IsChecked = w.WorkingDaysAndHours[5][1];
			c62.IsChecked = w.WorkingDaysAndHours[6][1];

			c03.IsChecked = w.WorkingDaysAndHours[0][2];
			c13.IsChecked = w.WorkingDaysAndHours[1][2];
			c23.IsChecked = w.WorkingDaysAndHours[2][2];
			c33.IsChecked = w.WorkingDaysAndHours[3][2];
			c43.IsChecked = w.WorkingDaysAndHours[4][2];
			c53.IsChecked = w.WorkingDaysAndHours[5][2];
			c63.IsChecked = w.WorkingDaysAndHours[6][2];

			c04.IsChecked = w.WorkingDaysAndHours[0][3];
			c14.IsChecked = w.WorkingDaysAndHours[1][3];
			c24.IsChecked = w.WorkingDaysAndHours[2][3];
			c34.IsChecked = w.WorkingDaysAndHours[3][3];
			c44.IsChecked = w.WorkingDaysAndHours[4][3];
			c54.IsChecked = w.WorkingDaysAndHours[5][3];
			c64.IsChecked = w.WorkingDaysAndHours[6][3];

			c05.IsChecked = w.WorkingDaysAndHours[0][4];
			c15.IsChecked = w.WorkingDaysAndHours[1][4];
			c25.IsChecked = w.WorkingDaysAndHours[2][4];
			c35.IsChecked = w.WorkingDaysAndHours[3][4];
			c45.IsChecked = w.WorkingDaysAndHours[4][4];
			c55.IsChecked = w.WorkingDaysAndHours[5][4];
			c65.IsChecked = w.WorkingDaysAndHours[6][4];


		}





		
		
		
	}
}
