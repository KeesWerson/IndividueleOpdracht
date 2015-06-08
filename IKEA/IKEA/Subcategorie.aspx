<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Subcategorie.aspx.cs" Inherits="IKEA.Subcategorie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Subcategorie.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    [Naam categorie]<br />
    [omschrijing]<br /><br />
    <div class="row">
        <a href="Hoofdpagina.aspx">
            <div class="item1">
                ITEM1
            </div>
        </a>
        <a href="Hoofdpagina.aspx">
            <div class="item2">
                ITEM2
            </div>
        </a>
        <a href="Hoofdpagina.aspx">
            <div class="item3">
                ITEM3
            </div>
        </a>
        <a href="Hoofdpagina.aspx">
            <div class="item4">
                ITEM4
            </div>
        </a>
    </div><br />
    <div class="row">
        <a href="Hoofdpagina.aspx">
            <div class="item1">
                ITEM5
            </div>
        </a>
        <a href="Hoofdpagina.aspx">
            <div class="item2">
                ITEM6
            </div>
        </a>
        <a href="Hoofdpagina.aspx">
            <div class="item3">
                ITEM7
            </div>
        </a>
        <a href="Hoofdpagina.aspx">
            <div class="item4">
                ITEM8
            </div>
        </a>
    </div>
    <br />
</asp:Content>
