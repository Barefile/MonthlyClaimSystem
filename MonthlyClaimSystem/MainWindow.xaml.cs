using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace ClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Implement login logic here
            MessageBox.Show("Login successful!"); // Placeholder for demonstration
        }

        private void UploadDocumentsButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf|Word Documents (*.docx)|*.docx|Excel Files (*.xlsx)|*.xlsx",
                Title = "Select Supporting Document"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                // Show the selected file name
                UploadedFileTextBlock.Text = openFileDialog.FileName;
                // You can implement logic to save this file path or copy the file as needed
            }
        }

        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Collect the claim data from the text fields
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string campus = CampusTextBox.Text;
            string program = ProgramTextBox.Text;
            string moduleTitle = ModuleTitleTextBox.Text;
            string email = EmailTextBox.Text;
            string month = (MonthComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            // Simulate saving claim data
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email))
            {
                // Here you would typically save to a database or file
                MessageBox.Show("Claim submitted successfully!");

                // Optionally, update the progress bar
                ClaimProgressBar.Value = 100;
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        private void ApproveClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to approve a claim
            MessageBox.Show("Claim approved!");
            // Update claims list or status as needed
        }

        private void RejectClaimButton_Click(object sender, RoutedEventArgs e)
        {
            // Logic to reject a claim
            MessageBox.Show("Claim rejected!");
            // Update claims list or status as needed
        }
    }
}
