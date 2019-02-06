using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZIP_FTP.Logic
{
  // Compares two ListView items based on a selected column.
  public class ListViewComparer : System.Collections.IComparer
  {
    private int ColumnNumber;
    private SortOrder SortOrder;

    // The column we are currently using for sorting.
    private static ColumnHeader SortingColumn = null;


    public ListViewComparer(int column_number, SortOrder sort_order)
    {
      ColumnNumber = column_number;
      SortOrder = sort_order;
    }

    // Compare two ListViewItems.
    public int Compare(object object_x, object object_y)
    {
      // Get the objects as ListViewItems.
      ListViewItem item_x = object_x as ListViewItem;
      ListViewItem item_y = object_y as ListViewItem;

      // Get the corresponding sub-item values.
      string string_x;
      if (item_x.SubItems.Count <= ColumnNumber)
      {
        string_x = "";
      }
      else
      {
        string_x = item_x.SubItems[ColumnNumber].Text;
      }

      string string_y;
      if (item_y.SubItems.Count <= ColumnNumber)
      {
        string_y = "";
      }
      else
      {
        string_y = item_y.SubItems[ColumnNumber].Text;
      }

      // Compare them.
      int result;
      double double_x, double_y;
      if (double.TryParse(string_x, out double_x) &&
          double.TryParse(string_y, out double_y))
      {
        // Treat as a number.
        result = double_x.CompareTo(double_y);
      }
      else
      {
        DateTime date_x, date_y;
        if (DateTime.TryParse(string_x, out date_x) &&
            DateTime.TryParse(string_y, out date_y))
        {
          // Treat as a date.
          result = date_x.CompareTo(date_y);
        }
        else
        {
          // Treat as a string.
          result = string_x.CompareTo(string_y);
        }
      }

      // Return the correct result depending on whether
      // we're sorting ascending or descending.
      if (SortOrder == SortOrder.Ascending)
      {
        return result;
      }
      else
      {
        return -result;
      }
    }

    public static void ColumnHeaderClickEvent(object sender, ColumnClickEventArgs e, ListView listView)
    {
      // Get the new sorting column.
      ColumnHeader new_sorting_column = listView.Columns[e.Column];

      // Figure out the new sorting order.
      System.Windows.Forms.SortOrder sort_order;
      if (SortingColumn == null)
      {
        // New column. Sort ascending.
        sort_order = SortOrder.Ascending;
      }
      else
      {
        // See if this is the same column.
        if (new_sorting_column == SortingColumn)
        {
          // Same column. Switch the sort order.
          if (SortingColumn.Text.StartsWith(@"/\ "))
          {
            sort_order = SortOrder.Ascending;
          }
          else
          {
            sort_order = SortOrder.Descending;
          }
        }
        else
        {
          // New column. Sort ascending.
          sort_order = SortOrder.Ascending;
        }

        // Remove the old sort indicator.
        SortingColumn.Text = SortingColumn.Text.Substring(2);
      }

      // Display the new sort order.
      SortingColumn = new_sorting_column;
      if (sort_order == SortOrder.Ascending)
      {
        SortingColumn.Text = @"\/ " + SortingColumn.Text.Trim();
      }
      else
      {
        SortingColumn.Text = @"/\ " + SortingColumn.Text.Trim();
      }

      // Create a comparer.
      listView.ListViewItemSorter =
          new ListViewComparer(e.Column, sort_order);

      // Sort.
      listView.Sort();
    }
  }
}
