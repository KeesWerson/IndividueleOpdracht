<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="IKEA.Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Item.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="itemcontainer">
        <div id="picture">
            test
        </div>
        <div id="info">
            <asp:Label ID="lblNaam" runat="server" Text="[NAAM]"></asp:Label><br />
            <asp:Label ID="lblSoortOmschr" runat="server" Text="[SOORT OMSCHR]"></asp:Label><br />
            <asp:Label ID="lblKosten" runat="server" Text="[KOSTEN]"></asp:Label><br />
            <asp:Label ID="lblArtNr" runat="server" Text="[ART.NR]"></asp:Label><br /><br />

            <asp:Label ID="lblOmschrijving" runat="server" Text="[OMSCHRIJVING]"></asp:Label><br /><br />

            <asp:TextBox ID="tbAantal" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="btnWinkelwagen" runat="server" Text="In winkelwagen" /><br />
            <asp:Button ID="btnVerlanglijst" runat="server" Text="Verlanglijstje" />
            <hr />
        </div>
    </div>
</asp:Content>
