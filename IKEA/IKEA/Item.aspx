<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="IKEA.Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Item.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="itemcontainer">
        <div runat="server" id="contentItemAfbeelding">
            <!-- Voorbeeld van hoe de gegenereerde code er uit komt te zien -->
            <!--<div id="picture">
                test
            </div>-->
        </div>
        <div id="info">
            <asp:Label ID="lblNaam" runat="server" Text="[NAAM]"></asp:Label><br />
            <asp:Label ID="lblSoortOmschr" runat="server" Text="[SOORT OMSCHR]"></asp:Label><br />
            <asp:Label ID="lblKosten" runat="server" Text="[KOSTEN]"></asp:Label><br />
            <asp:Label ID="lblArtNr" runat="server" Text="[ART.NR]"></asp:Label><br /><br />

            <asp:Label ID="lblOmschrijving" runat="server" Text="[OMSCHRIJVING]"></asp:Label><br /><br />

            <asp:TextBox ID="tbAantal" runat="server" MaxLength="3" Width="29px"></asp:TextBox>
            <asp:Label ID="lblAantalError" runat="server" Text="Voer het aantal gewenste items in." ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:Button ID="btnWinkelwagen" runat="server" Text="In winkelwagen" OnClick="btnWinkelwagen_Click" /><br />
            <asp:Button ID="btnVerlanglijst" runat="server" Text="Verlanglijstje" OnClick="btnVerlanglijst_Click" />
            <hr />
        </div>
    </div>
</asp:Content>
