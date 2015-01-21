//Tajwane Campbell & Karlessa Howard
 
/*This form application was built for the NCU bookstore and it allows a user to perform CRUD operations
 * on records in a database. That is, it allows a user to add a new book record, search for a record 
 * (by the book's ID, author's name, publisher and Title), select a record to update or delete and
 * view all the records in the database using LINQ*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advance_app_linq
{
    public partial class Form1 : Form
    {
        dbLinqDataContext db;
        long selectedID;
        public Form1()
        {
            InitializeComponent();
            db = new dbLinqDataContext();
            selectedID = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'linqDataSet.book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.linqDataSet.book);

        }


         /* Description =An action listener function that calls the search function each time user clicks search button
        * Precondition = Database & table must exist  and user must enter value in textbox
        * Postcondition =
        */
        private void search_btn_Click(object sender, EventArgs e)
        {
            search();
            if (output_gridView.RowCount <= 1)
                MessageBox.Show("No Match Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
        }
        

        /* Description = Function to get and display all the records which matches the search criterion
        * Precondition = Database & table must exist 
        * Postcondition = The records that match the search criteria are displayed in a datagridview
        */
        private void search()
        {
            try
            {
                if (db.DatabaseExists())
                {
                    long intVal;
                    
                   
                   
                    

                 //   DataGridViewRow selected = test.Rows[2];// output_gridView.Rows[1];
                    
                    var book = from s in db.books select s;
                    if (Int64.TryParse(search_txtBox.Text, out intVal))//test if user input can be parsed to an integer value then ouputs it to a long type variable
                    {
                        book = from s in db.books
                               where s.bookID == intVal
                               select s;

                     }
                    else
                    {
                        book = from s in db.books
                               where s.title.Contains(search_txtBox.Text.ToString()) || s.publisher.Contains(search_txtBox.Text.ToString()) ||  s.author.Contains(search_txtBox.Text.ToString())
                               select s;
                    }
                    output_gridView.DataSource = book;
                    
                   
                  
                      
                }
            }
            catch (Exception x)
            {
                errorMessage(x.Message.ToString(), "Search Data Error");
            }
        }
      

         // Description = Function that calls the search function each time user enters input into search box
        private void search_txtBox_KeyUp(object sender, KeyEventArgs e)
        {
            search();
        }


         /* Description =Action listener function to get and display the data from the selecetd row in the respective text box 
        * Precondition = User must select a row
        * Postcondition = The records in the table are displayed in the datagrid view
        */
        private void output_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (db.DatabaseExists()) //checks databse State
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow selected = this.output_gridView.Rows[e.RowIndex];
                        title_lable.Text = selected.Cells["titleDataGridViewTextBoxColumn"].Value.ToString();
                        yearPub_lable.Text = selected.Cells["yearPublishedDataGridViewTextBoxColumn"].Value.ToString();
                        pub_lable.Text = selected.Cells["publisherDataGridViewTextBoxColumn"].Value.ToString();
                        quant_txtBox.Text = selected.Cells["quantityDataGridViewTextBoxColumn"].Value.ToString();
                        price_txtBox.Text = selected.Cells["priceDataGridViewTextBoxColumn"].Value.ToString();
                        author_label.Text = selected.Cells["authorDataGridViewTextBoxColumn"].Value.ToString();
                        selectedID = Convert.ToInt64(selected.Cells["bookIDDataGridViewTextBoxColumn"].Value.ToString());

                    }
                   
                }
            }
            catch (Exception xe)
            {
                errorMessage(xe.Message.ToString(), "Data Selection Error");
            }
        }


         /* Description =An action listener function to update user selcted record
        * Precondition = User must select a record from datagridview
        * Postcondition = The record the user selected is updated with the user's input 
          * Example = quantity = 2 after function(update) quantity = 9
        */
        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.DatabaseExists())
                {
                    if (selectedID == 0)
                        errorMessage("You must first select a book you would like to update", "Update Error");
                    else
                    {
                        if (confirmed("Are you sure you want to update this Book", "Confirm Book Update"))
                        {
                            book update = db.books.Single(b => b.bookID == Convert.ToInt32(selectedID));
                            update.price = Convert.ToDecimal(price_txtBox.Text.ToString());
                            update.quantity = Convert.ToInt16(quant_txtBox.Text.ToString());
                            db.SubmitChanges();
                            selectedID = 0;
                            operationComplete("Update Operation Completed", "Update Book Operation");
                            clearFields();
                            getData();
                        }
                    }
                }
            }
            catch(Exception x){
                errorMessage(x.Message.ToString(), "Update Data Error");
            }
      }


        //Displays a simple error message box
        private void errorMessage(String message, String title) {
            DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
           }


         /* Description = Function that returns true or false if user selects yes or no respectively from dialog box
        * Precondition = Message to be displayed and title of message box as string arguments
          * (arguments) -> return type = (string, string) -> boolean
        * Postcondition = Returns true or false
        */
        private Boolean confirmed(String message, String title){
           DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if(DialogResult.Yes == dialogResult)
               return true;
               return false;
        }


         /* Description = An action listener function to delete a user selected record from the database
        * Precondition = Database & table must exist and user must select a record
        * Postcondition = The record selected by the user is deleted from the database
          */
        private void delete_btn_Click(object sender, EventArgs e)
        {
            try{
                if (db.DatabaseExists())
                {
                    if (selectedID == 0)
                        MessageBox.Show("You must first select a book you would like to delete", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        if (confirmed("Are you sure you want to delete this Book", "Confirm Book Delete"))
                        {
                            book delete = db.books.Single(b => b.bookID == Convert.ToInt32(selectedID));
                            db.books.DeleteOnSubmit(delete);
                            db.SubmitChanges();
                            selectedID = 0;
                            operationComplete("Delete Operation Completed", "Delete Book Operation");
                            clearFields();
                            getData();
                        }
                    }
                }
            }
            catch(Exception x){
                errorMessage(x.Message.ToString(), "Delete Data Error");
            }


        }

         /* Description = An action listener function to add user input to database
          * Precondition = Database & table must exist and user input must not be null
        * Postcondition = The record is added to the table 
        */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.DatabaseExists())
                {
                    if (confirmed("Are you sure you want to add this Book", "Confirm Addition of Book"))
                    {
                        var books = new book
                        {
                            title = Convert.ToString(title_txtbox.Text),
                            author = Convert.ToString(author_txtbox.Text),
                            publisher = Convert.ToString(pub_txtbox.Text),
                            yearPublished = Convert.ToString(pubYear_txtbox.Text),
                            quantity = Convert.ToInt16(quantity_txtbox.Text),
                            price = Convert.ToDecimal(price_textbox.Text),
                        };
                        db.books.InsertOnSubmit(books);
                        db.SubmitChanges();
                        operationComplete("Insertion Operation Completed", "Book Insertion");
                        clearFields();//Clears input fields
                        getData();//refreshes the data grid view
                        
                    }
                  }
                }//end of try
                catch (Exception x)
                {
                    MessageBox.Show(x.Message.ToString(), "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }


       /* Description =An action listener function that calls a clear fields function when the "clear" button is clicked.
        *Postcondition = the textboxes values are cleared 
        */
        private void button2_Click(object sender, EventArgs e)
        {

            clearFields();

        }

        private void clearFields() {
            title_txtbox.Text = "";
            author_txtbox.Text = "";
            pub_txtbox.Text = "";
            pubYear_txtbox.Text = "";
            price_textbox.Text = "";
            quantity_txtbox.Text = "";
            title_lable.Text = "";
            price_txtBox.Text = "";
            quant_txtBox.Text = "";
            pub_lable.Text = "";
            yearPub_lable.Text = "";
            author_label.Text = "";


        }


       /* Description = Function to get and display all the records in database in datagridview
        * Precondition = Database & table must exist 
        * Postcondition = The records in the table are displayed in the datagridview
        */
        private void getData() {
            try
            {
                if (db.DatabaseExists())
                {
                    var data = from d in db.books select d;

                    output_gridView.DataSource = data;
                }
            }
            catch (Exception e) {
                errorMessage(e.Message.ToString(), "Get Data Error");
            }
        }


        private void operationComplete(String message, String title) {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      
    }
}

