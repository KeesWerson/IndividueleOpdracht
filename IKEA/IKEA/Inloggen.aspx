<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Inloggen.aspx.cs" Inherits="IKEA.Inloggen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Inloggen.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Inloggen of een profiel aanmaken.</h3>
    <h3>Denk eraan om regelmatig je wachtwoord te wijzigen.</h3>
    <div id="inlogcontainer">
        <br />
        <div class="inlogsectie">
            <h3>Inloggen</h3>
            <hr /><br /><br /><br />
            <asp:Label ID="lblGebruikersnaam" runat="server" Text="Gebruikersnaam: "></asp:Label>     
            <asp:TextBox ID="tbGebruikersnaam" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblWachtwoord" runat="server" Text="Wachtwoord: "></asp:Label>   
            <asp:TextBox ID="tbWachtwoord" runat="server"></asp:TextBox><br />
            <br /><br /><br /><hr /><br />
            <asp:Button ID="Login" runat="server" Text="Inloggen" />
        </div>
        <div class="registreersectie">
            <h3>Waarom een profiel aanmaken?</h3>
            <hr />
            <h5><b>Met een eigen profiel haal je meer uit IKEA.nl:</b></h5>
            <h5>Je kan zoveel boodschappenlijstjes opslaan als je wilt. Ook kan je
                 je ontwerpen uit de 3D Keukenplanner en andere online planners bewaren
                 en vanaf elke pc, ook in de winkel, openen. En daarnaast kan je heel
                 gemakkelijk lid worden van IKEA FAMILY.</h5><br />
            <asp:Button ID="Registreer" runat="server" Text="Profiel aanmaken" OnClick="Registreer_Click"/>
        </div>
    </div>
    <br /><br /><br />
</asp:Content>
