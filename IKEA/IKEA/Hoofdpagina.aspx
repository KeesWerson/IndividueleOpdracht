<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Hoofdpagina.aspx.cs" Inherits="IKEA.Hoofdpagina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/hoofdpagina.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="largeimg">
        test1
    </div>
    <br /> <!--GIT TESTING -->
    <div id="mediumcontainer">
        <div class="mediumimg1">
            test2
        </div>
        <div class="mediumimg2">
            test2.1
        </div>
    </div>
    <br />
    <div id="smallcontainer">
        <div class="smallimg1">
            test3
        </div>
        <div class="smallimg2">
            test3.1
        </div>
        <div class="smallimg3">
            test3.2
        </div>
    </div>
    <br />
</asp:Content>
