using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        // Declares an array that can hold up to 20 products
        Product[] products = new Product[20];

        // Represents number of products in the array
        int productCount = 5;

        // Represents active product for operations
        Product activeProduct;

        public Form1()
        {
            InitializeComponent();

            // Creates 5 products
            products[0] = new Product("USB-A to USB-C 3ft Cable", "000001", 5.99m, 179.70m, 30, "Inland");
            products[1] = new Product("USB-A to USB-C 6ft Cable", "000002", 9.99m, 199.80m, 20, "Inland");
            products[2] = new Product("USB-A to USB-C 10ft Cable", "000003", 14.99m, 239.84m, 16, "Inland");
            products[3] = new Product("USB-C to USB-C 3ft Cable", "000004", 6.99m, 209.70m, 30, "Inland");
            products[4] = new Product("USB-C to USB-C 6ft Cable", "000005", 10.99m, 219.80m, 20, "Inland");
        }

        private void SearchByName(string input)
        {
            // Determines if product has been found
            bool productFound = false;

            for (int i = 0; i < productCount; i++)
            {
                if (products[i].Name.ToLower().Contains(input.ToLower()) && !productFound)
                {
                    // Sets active product to product with name that contains input
                    activeProduct = products[i];

                    // Prevents loop from iterating through every product available
                    productFound = true;
                }
            }
        }

        private void SearchByUpc(string input)
        {
            // Determines if product has been found
            bool productFound = false;

            for (int i = 0; i < productCount; i++)
            {
                if (products[i].UPC == input && !productFound)
                {
                    // Sets active product to product with name that contains input
                    activeProduct = products[i];

                    // Prevents loop from iterating through every product available
                    productFound = true;
                }
            }
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            string name = txtNameSearch.Text;
            SearchByName(name);
        }

        private void btnSearchUpc_Click(object sender, EventArgs e)
        {
            string upc = txtUpcSearch.Text;
            SearchByUpc(upc);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {




















































































































































































































































        }
    }
}
