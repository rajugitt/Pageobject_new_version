using OpenQA.Selenium;
using OpenQA.Selenium.Chrome; // Make sure to include the necessary driver
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

class Driver
{

    static void Main(string[] args)
    {
        try
        {
            // Step 1: Initialize Excel and WebDriver
            ChartAccountsTest.InitializeExcelAndWebDriver();
            Thread.Sleep(5000);

            // Step 2: Perform Login
            ChartAccountsTest.PerformLogin();
            Thread.Sleep(5000);

            Thread.Sleep(5000);
            // Step 3: Navigate to the Chart of Accounts and create an account
            ChartAccountsTest.NavigateToChartOfAccountsAndCreateAccount();
            Thread.Sleep(5000);
            // Step 4: Search for the created account
            ChartAccountsTest.SearchForAccount();
            Thread.Sleep(5000);

            ChartAccountsTest.editaccount();
            // Step 5: Optionally, perform further actions like editing, deleting, etc.
            // ChartAccountsTest.EditAccount();
            // ChartAccountsTest.DeleteAccount();

            // Step 6: Save changes to Excel (if required)
            ChartAccountsTest.SaveChangesToExcel();
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            // Step 7: Cleanup resources
            ChartAccountsTest.Cleanup();

        }
        Console.ReadLine();
    }

}
