<%@ Control Language="C#" ClassName="AdminHeader" %>

<script runat="server">

    protected void Page_Load(object sender, EventArgs e)
    {

    }
</script>
<link rel="stylesheet" type="text/css" href="/admin/styles/ddcolortabs.css"/>
<script language="JavaScript" type="text/javascript" src="/admin/js/home_menu.js"></script>

<%--<div id="menu">
<div style="float:left;width:210px;background-color: #005C8F"><a href="/admin">INR - CLN Admin</a></div>
<div style="float:left" id="colortab" class="ddcolortabs">
<ul>
	<li><a title="Go Server" rel="GoServer"><span>Go Server</span></a></li>
	<li><a title="Comments" rel="Comments"><span>Comments</span></a></li>
	<li><a title="Astro" rel="Astro"><span>Astro</span></a></li>
	<li><a title="Others" rel="Others"><span>Others</span></a></li>
	<li><a title="COLHP" rel="COLHP"><span>COL HP</span></a></li>
	<li><a title="ConTrack" rel="ConTrack"><span>Con-Track</span></a></li>
	<li><a title="CMS" href="/admin/colcms/"><span>CMS</span></a></li>
	<li><a title="COLHP" href="/"><span>COL Home</span></a></li>
	
</ul>
</div>
<!-- "GoServer" drop down menu -->                                                   
	<div id="GoServer" class="dropmenudiv_a">
		<a href="/admin/goserver/pageviews.aspx">Page Views</a>
		<a href="/goserver/GoList.asp">Clicks</a>
	</div>

<!-- "Comments" drop down menu -->                                                   
	<div id="Comments" class="dropmenudiv_a">
	    <a href="/admin/articlecomments/ModerateComments.aspx">Review & Post Comments</a>
		<a href="/admin/articlecomments/PostedComments.aspx">View Posted Comments</a>
		<a href="/admin/articlecomments/StatisticsComments.aspx">Statistics</a> 
	</div>
	<!-- "astro" drop down menu -->                                                   
	<div id="Astro" class="dropmenudiv_a">
	    <a href="/admin/astro/dailyprediction/dailyadmin.aspx">Daily Predictions</a>
	</div>

	
	<!-- "Others" drop down menu -->                                                   
	<div id="Others" class="dropmenudiv_a">
	    <a href="/admin/COLEVENTS/Event_List.aspx">Events Track</a>
		<a href="http://tamil-news.in/admin/">TNS Admin</a>
		<a href="/admin/video/">Video</a>
		<a href="/admin/coltamilvideo/videolist.aspx">Tamil Video</a>
		<a href="http://chennaidigest.in/admin/login.aspx">e-Paper</a>
	</div>

<div id="COLHP" class="dropmenudiv_a">
		<a href="/admin/ContentSlider/Content_Slider_Admin.aspx">Content Slider</a>
		<a href="/admin/COLHPV1/Article_Lead_Admin1.aspx">Articles Lead admin</a>
		<a href="/admin/COLHPV1/Article_Lead_Category_Admin1.aspx">Articles Lead Category admin</a>
	</div>
	
	<div id="ConTrack" class="dropmenudiv_a">
		<a href="/admin/ConTracker/author_Lead_Add_New.aspx">Submit Article</a>
		<a href="/admin/ConTracker/Lead_Category_Admin.aspx">View Report</a>
		<a href="/admin/ConTracker/author_Lead_Category_Admin.aspx">Author List</a>
	</div>

<!-- End topnavigation -->

<script type="text/javascript">
//SYNTAX: tabdropdown.init("menu_id", [integer OR "auto"])
//tabdropdown.init("colortab", 1)
tabdropdown.init("colortab")
</script>
</div>--%>
