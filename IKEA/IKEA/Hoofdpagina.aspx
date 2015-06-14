<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Hoofdpagina.aspx.cs" Inherits="IKEA.Hoofdpagina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/hoofdpagina.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="largeimg">
        <img src ="Images/hoofdpagina_groot.jpg" width="1000px" height="410px"/>
    </div>
    <br />
    <div id="mediumcontainer">
        <div class="mediumimg1">
            <img src ="Images/hoofdpagina_middel1.jpg" width="490px" height="210px"/>
        </div>
        <div class="mediumimg2">
            <img src ="Images/hoofdpagina_middel2.jpg" width="490px" height="210px"/>
        </div>
    </div>
    <br />
    <div id="smallcontainer">
        <div class="smallimg1">
            <img src ="Images/hoofdpagina_klein1.jpg" width="320px" height="230px"/>
        </div>
        <div class="smallimg2">
            <img src ="Images/hoofdpagina_klein2.jpg" width="320px" height="230px"/>
        </div>
        <div class="smallimg3">
            <img src ="Images/hoofdpagina_klein3.jpg" width="320px" height="230px"/>
        </div>
    </div>
    <br />
</asp:Content>
