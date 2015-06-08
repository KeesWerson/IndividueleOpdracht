<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Hoofdcategorie.aspx.cs" Inherits="IKEA.Hoofdcategorie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Hoofdcategorie.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div id="catcontainer">
        <div id="sublijsttekst">
            <ul class="catlist">
                <li><a class="catlink" href="www.google.nl"><b>DB_HOOFCAT</b></a>
                    <ul class="catlist">
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                    </ul></li>
                <li><a class="catlink" href="www.google.nl"><b>DB_HOOFCAT</b></a>
                    <ul class="catlist">
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                    </ul></li>
                <li><a class="catlink" href="www.google.nl"><b>DB_HOOFCAT</b></a>
                    <ul class="catlist">
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                    </ul></li>
                <li><a class="catlink" href="www.google.nl"><b><b>DB_HOOFCAT</b></b></a>
                    <ul class="catlist">
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                        <li><a class="catlink" href="www.google.nl">DB_subcat</a></li>
                    </ul>
                </li>
            </ul>
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
