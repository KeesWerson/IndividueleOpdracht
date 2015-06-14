<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Registreren.aspx.cs" Inherits="IKEA.Registreren" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Registreren.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="registratiecontainer">
        <h4>Een profiel aanmaken</h4>
        Als je een profiel aanmaakt, kan je nog veel meer uit onze website halen 
        <div id="registratie">
            <h3>Maak een profiel aan</h3>
            <hr /><br />
            <asp:Label ID="lblGebruikersnaam" runat="server" Text="* Gebruikersnaam "></asp:Label>
            <asp:TextBox ID="tbGebruikersnaam" runat="server"></asp:TextBox>
            <asp:Label ID="lblGebruikersnaamError" runat="server" Text="verplicht veld" ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:Label ID="lblVoornaam" runat="server" Text="* Voornaam "></asp:Label>
            <asp:TextBox ID="tbVoornaam" runat="server"></asp:TextBox>
            <asp:Label ID="lblVoornaamError" runat="server" Text="verplicht veld" ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:Label ID="lblAchternaam" runat="server" Text="* Achternaam "></asp:Label>
            <asp:TextBox ID="tbAchternaam" runat="server"></asp:TextBox>
            <asp:Label ID="lblAchternaamError" runat="server" Text="verplicht veld" ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:Label ID="lblTelnrMobiel" runat="server" Text="Telefoonnummer mobiel "></asp:Label>
            <asp:TextBox ID="tbTelnrMobiel" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="lblEmail" runat="server" Text="* E-mailadres "></asp:Label>
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            <asp:Label ID="lblEmailError" runat="server" Text="verplicht veld" ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:Label ID="lblEmailOpnieuw" runat="server" Text="* E-mail opnieuw invullen "></asp:Label>
            <asp:TextBox ID="tbEmailOpnieuw" runat="server"></asp:TextBox>
            <asp:Label ID="lblEmailOpnieuwError" runat="server" Text="verplicht veld" ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:Label ID="lblWachtwoord" runat="server" Text="* Wachtwoord "></asp:Label>
            <asp:TextBox ID="tbWachtwoord" runat="server"></asp:TextBox>
            <asp:Label ID="lblWachtwoordError" runat="server" Text="verplicht veld" ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:Label ID="lblWachtwoordOpnieuw" runat="server" Text="* Wachtwoord bevestigen "></asp:Label>
            <asp:TextBox ID="tbWachtwoordOpnieuw" runat="server"></asp:TextBox>
            <asp:Label ID="lblWachtwoordOpnieuwError" runat="server" Text="verplicht veld" ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:CheckBox ID="cbVoorwaarden" runat="server" />
            <asp:Label ID="lblVoorwaarden" runat="server" Text="* Ik ga akkoord met de voorwaarden"></asp:Label>
            <asp:Label ID="lblVoorwaardenError" runat="server" Text="Accepteer de voorwaarden." ForeColor="Red" Visible="False"></asp:Label>
            <br /><hr />
            <asp:Button ID="btnTerug" runat="server" Text="Terug" OnClick="btnTerug_Click" />
            <asp:Button ID="btnOpslaan" runat="server" Text="Opslaan en doorgaan" OnClick="btnOpslaan_Click" />
        </div>
    </div>
    <br />
</asp:Content>
