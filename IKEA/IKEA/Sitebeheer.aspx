<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Sitebeheer.aspx.cs" Inherits="IKEA.Sitebeheer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Systeembeheer.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="SysteemContainer">
        <div class="ItemAdder">
            <h3>Add Item</h3>
            <!-- De textboxes voor het toevoegen van een ITEM -->
            <asp:Label ID="lblCategorie" runat="server" Text="CategorieID"></asp:Label>
            <asp:TextBox ID="tbCategorie" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblSoort" runat="server" Text="Soort"></asp:Label>
            <asp:TextBox ID="tbSoort" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblNaam" runat="server" Text="Naam"></asp:Label>
            <asp:TextBox ID="tbNaam" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPoductomschr" runat="server" Text="Productomschrijving"></asp:Label>
            <asp:TextBox ID="tbProductomschr" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPrijs" runat="server" Text="Prijs"></asp:Label>
            <asp:TextBox ID="tbPrijs" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnAddItem" runat="server" Text="Maak aan" OnClick="btnAddItem_Click" />
        </div>
        <div class="CategorieAdder">
            <h3>Add Categorie</h3>
            <!-- De textboxes voor het toevoegen van een CATEGORIE -->
            <asp:Label ID="lblSubCat" runat="server" Text="SubCategorieID"></asp:Label>
            <asp:TextBox ID="tbSubCat" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblCatNaam" runat="server" Text="Categorienaam"></asp:Label>
            <asp:TextBox ID="tbCatNaam" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblOmschrijving" runat="server" Text="Omschrijving"></asp:Label>
            <asp:TextBox ID="tbOmschrijving" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnAddCategorie" runat="server" Text="Maak aan" OnClick="btnAddCategorie_Click" />
        </div>
    </div>
    <br />
</asp:Content>
