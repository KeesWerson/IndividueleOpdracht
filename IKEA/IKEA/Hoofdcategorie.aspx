<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Hoofdcategorie.aspx.cs" Inherits="IKEA.Hoofdcategorie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Hoofdcategorie.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div id="catcontainer">
        <!-- Dynamische plek waar de Hoofd- en subcategoriee worden gegenereerd. -->
        <div runat="server" id="contentCategorieLink">
            <!-- Voorbeeld van hoe de gegenereerde code er uit komt te zien -->
            <!--<div id="sublijsttekst">
                <ul class="catlist">
                    <li><b>DB_HOOFCAT</b>
                        <ul class="catlist">
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                        </ul></li>
                    <li><b>DB_HOOFCAT</b>
                        <ul class="catlist">
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                        </ul></li>
                    <li><b>DB_HOOFCAT</b>
                        <ul class="catlist">
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                        </ul></li>
                    <li><b>DB_HOOFCAT</b>
                        <ul class="catlist">
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                            <li><a class="catlink" href="Subcategorie.aspx">DB_subcat</a></li>
                        </ul>
                    </li>
                </ul>
            </div>-->
        </div>
        <!--<div runat="server" id="contentCategorieAfbeelding">-->
            <!-- Voorbeeld van hoe de gegenereerde code er uit komt te zien -->
            <div id="sublijstafb">
                <div class="largeimg">
                    <img src ="Images/ikealogo.gif" width="780px" height="400px"/>
                </div>
                <br />
                <div id="mediumcontainer">
                    <div class="mediumimg">
                        <img src ="Images/ikealogo.gif" width="500px" height="539px"/>
                    </div>
                    <div class="cubeimg1">
                        <img src ="Images/ikealogo.gif" width="260px" height="260px"/>
                    </div>
                    <div class="cubeimg2">
                        <img src ="Images/ikealogo.gif" width="260px" height="260px"/>
                    </div>
                </div>
            </div>
        <!--</div>-->
    </div>
</asp:Content>
