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
        <div id="sublijstafb">
            <div class="largeimg">
                test1
            </div>
            <br />
            <div id="mediumcontainer">
                <div class="mediumimg">
                    test2
                </div>
                <div class="cubeimg1">
                    test3.1
                </div>
                <div class="cubeimg2">
                    test3.2
                </div>
            </div>
        </div>
    </div>
</asp:Content>
