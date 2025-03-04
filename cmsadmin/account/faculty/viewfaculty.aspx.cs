using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class admin_account_about_ViewNews : System.Web.UI.Page
{
    pmufaculty faculty = new pmufaculty();
    pmuLogin login = new pmuLogin();
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
            BindContent();
    }
  
    protected void OnPaging(object sender, GridViewPageEventArgs e)
    {

        BindContent();

        grvFaculty.PageIndex = e.NewPageIndex;

        grvFaculty.DataBind();

    }
    protected void ddlDepartment_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindContent();
    }
    public string BindPopup(string Image)
    {
        if (!string.IsNullOrEmpty(Image))
        {
            string filePath = System.Configuration.ConfigurationManager.AppSettings["FacultyImages"];
            string temppath = filePath.Trim() +"/" + Image;
            string newpath = "newPopup('" + temppath + "')";
            return newpath;
        }
        else
            return "";
    }
   
    public void BindContent()
    {
        try
        {
           
            DataSet dsContent = new DataSet();
            string stDepartment = ddlDepartment.SelectedItem.Text.Trim();
            if (!string.Equals(stDepartment,"All"))
                dsContent = faculty.ViewAllFacultyByDepartment(stDepartment);
            else
                dsContent = faculty.ViewAllFaculty();

            if (dsContent.Tables.Count > 0 && dsContent.Tables[0].Rows.Count > 0)
            {
                lblcheck.Text = "";
                grvFaculty.Visible = true;
                grvFaculty.DataSource = dsContent;
                grvFaculty.DataBind();
            }
            else
            {
                lblcheck.Visible = true;
                grvFaculty.Visible = false;
                lblcheck.Text = "No Faculty Added";
            }

        }
        catch (Exception ex)
        {
        }
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        //try
        //{
            LinkButton btnDelete = sender as LinkButton;
            GridViewRow row = (GridViewRow)btnDelete.NamingContainer;
            string[] args = btnDelete.CommandArgument.Split(';');
            int ID = Convert.ToInt16(args[0]);
            string HeaderImage = Convert.ToString(args[1]);
            if (!string.IsNullOrEmpty(HeaderImage))
                FileDelete(HeaderImage);
            string pdf1Image = Convert.ToString(args[2]);
            if (!string.IsNullOrEmpty(pdf1Image))
                FilePDFDelete(pdf1Image);
           
            faculty.DeleteFaculty(ID);
            BindContent();
        //}
        //catch (Exception ex)
        //{
        //}
    }
    protected void Statusimg_click(object sender, EventArgs e)
    {
        try
        {
            ImageButton imgRead = sender as ImageButton;
            GridViewRow row = (GridViewRow)imgRead.NamingContainer;
            int Sno = int.Parse(imgRead.CommandArgument);
            faculty.UpdateFacultyStatus(Sno,login.GetUserName(),Utility.IndianTime);
            BindContent();
        }
        catch (Exception ex)
        {
        }
    }
   
    
    
    public string bindImage(int imgId)
    {

        if (imgId == 1)
        {
            return "/cmsadmin/images/tick.png";
        }
        else
        {

            return "/cmsadmin/images/untick.png";
        }
    }
    public string bindDate(DateTime dt)
    {

        return dt.ToShortDateString();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("addfaculty.aspx", true);
    }
    
    public string bindImageHref(string ImageUrl)
    {

        if (!string.IsNullOrEmpty(ImageUrl))
        {
            return "javascript:void(0);";
        }
        else
        {

            return " ";
        }
    }
    public string bindUrl(string stDepartment)
    {
        string url = string.Empty;
        url = "https://pmu.edu/" + GetDepartmentAlbum(stDepartment) + "/" + "faculty.aspx";
        return url;
    }
    public string bindImageTitle(string Image)
    {

        if (!string.IsNullOrEmpty(Image))
        {
            return Image.Trim();
        }
        else
        {

            return "No Image";
        }
    }
    public void FileDelete(string ImageName)
    {

        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["FacultyImages"]);
        filePath += "//" + ImageName.Trim();

        // Delete a file by using File class static method... 
        if (System.IO.File.Exists(filePath))
        {
            // Use a try block to catch IOExceptions, to 
            // handle the case of the file already being 
            // opened by another process. 
            try
            {
                System.IO.File.Delete(filePath);

            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
    public string GetDepartmentAlbum(string stDepartment)
    {
        string stAlbum = string.Empty;       
         if (string.Equals(stDepartment, "Department of Architecture"))
            stAlbum = "department-of-architecture-new";
        else if (string.Equals(stDepartment, "Department of Aerospace Engineering"))
            stAlbum = "department-of-aerospace";
        else if (string.Equals(stDepartment, "Department of Bio-Technology"))
            stAlbum = "department-of-biotechnology";
        if (string.Equals(stDepartment, "Department of Chemical Engineering"))
            stAlbum = "department-of-chemical-engineering";
        if (string.Equals(stDepartment, "Department of Civil Engineering"))
            stAlbum = "department-of-civil-engineering";
        if (string.Equals(stDepartment, "Department of Electronics and Communication Engineering"))
            stAlbum = "department-of-electronics-and-communication";
        if (string.Equals(stDepartment, "Department of Electrical and Electronics Engineering"))
            stAlbum = "department-of-electrical-and-electronics";
        if (string.Equals(stDepartment, "Department of Mechanical Engineering"))
            stAlbum = "department-of-mechanical-engineering";
        if (string.Equals(stDepartment, "Division of Nanotechnology"))
            stAlbum = "department-of-nano-technology";
        if (string.Equals(stDepartment, "Department of Computer Science and Engineering"))
            stAlbum = "department-of-computer-science-engineering";
        if (string.Equals(stDepartment, "Department of Computer Science & Application"))
            stAlbum = "department-of-computer-science-applications";
        if (string.Equals(stDepartment, "Department of Software Engineering"))
            stAlbum = "department-of-software-engineering";
        if (string.Equals(stDepartment, "Department of Chemistry"))
            stAlbum = "department-of-chemistry";
        if (string.Equals(stDepartment, "Department of Commerce"))
            stAlbum = "department-of-commerce";
        if (string.Equals(stDepartment, "Department of English"))
            stAlbum = "department-of-english";
        if (string.Equals(stDepartment, "Department of Education"))
            stAlbum = "department-of-education";
        if (string.Equals(stDepartment, "Department of Mathematics"))
            stAlbum = "department-of-mathematics";
        if (string.Equals(stDepartment, "Department of Management Studies"))
            stAlbum = "department-of-management-studies";
        if (string.Equals(stDepartment, "Department of Physics"))
            stAlbum = "department-of-physics";
        if (string.Equals(stDepartment, "Department of Political Science"))
            stAlbum = "department-of-political-science";
        if (string.Equals(stDepartment, "Department of Social Work"))
            stAlbum = "department-of-social-work";
        if (string.Equals(stDepartment, "Centre for Institute Industry Interaction"))
            stAlbum = "Centre-for-Institute-Industry-Interaction";
        if (string.Equals(stDepartment, "Centre for Student and Administrative Services"))
            stAlbum = "Centre-for-Student-and-Administrative-Services";  
        if (string.Equals(stDepartment, "Dr.Kalaingar M.Karunanidhi Centre for Political Science"))
            stAlbum = "Kalaingar-Karunanidhi-Centre-for-Political-Science";
        if (string.Equals(stDepartment, "Veeramani Mohana Centre for Quality of Life Engineering Research"))
            stAlbum = "v-m-c-q-l-e-r"; 
         if (string.Equals(stDepartment, "Periyar Pura Centre for Rural Development"))
            stAlbum = "Periyar-Pura-Centre-for-Rural-Development";  
        if (string.Equals(stDepartment, "Centre of Excellence of Training and Research in Automation Technology"))
            stAlbum = "cet-rat";
        if (string.Equals(stDepartment, "Centre of Excellence for Next Generation Networks"))
            stAlbum = "cen-gn"; 
        if (string.Equals(stDepartment, "Centre of Excellence for Periyar Thought"))
            stAlbum = "ce-pt";  
        if (string.Equals(stDepartment, "Centre for Energy and Environment"))
            stAlbum = "entre-for-Energy-and-Environment";
        if (string.Equals(stDepartment, "Institution Innovation Council"))
            stAlbum = "Institution-Innovation-Council"; 

        return stAlbum;

    }
    public void FilePDFDelete(string pdfName)
    {

        string filePath = HttpContext.Current.Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["Facultypdf"]);
        filePath += "//" + pdfName.Trim();

        // Delete a file by using File class static method... 
        if (System.IO.File.Exists(filePath))
        {
            // Use a try block to catch IOExceptions, to 
            // handle the case of the file already being 
            // opened by another process. 
            try
            {
                System.IO.File.Delete(filePath);

            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}