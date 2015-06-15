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
            <asp:RequiredFieldValidator ID="rfvGebruikersnaam" runat="server" ControlToValidate="tbGebruikersnaam" Display="Dynamic" ErrorMessage="Gebruikersnaam is verplicht." ForeColor="Red" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="lblGebruikersnaam" runat="server" Text="Gebruikersnaam "></asp:Label>
            <asp:TextBox ID="tbGebruikersnaam" runat="server" ValidationGroup="AllValidators" CausesValidation="false"></asp:TextBox>
            <asp:Label ID="lblGebruikersnaamError" runat="server" Text="Niet uniek." ForeColor="Red" Visible="False"></asp:Label><br /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbVoornaam" Display="Dynamic" ErrorMessage="Voornaam is verplicht." ForeColor="Red" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="lblVoornaam" runat="server" Text="Voornaam "></asp:Label>
            <asp:TextBox ID="tbVoornaam" runat="server"></asp:TextBox><br /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbAchternaam" Display="Dynamic" ErrorMessage="Achternaam is verplicht." ForeColor="Red" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="lblAchternaam" runat="server" Text="Achternaam "></asp:Label>
            <asp:TextBox ID="tbAchternaam" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="lblTelnrMobiel" runat="server" Text="Telefoonnummer mobiel "></asp:Label>
            <asp:TextBox ID="tbTelnrMobiel" runat="server" MaxLength="10" Width="73px"></asp:TextBox><br /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbEmail" Display="Dynamic" ErrorMessage="E-mail is verplicht." ValidationGroup="AllValidators" ForeColor="Red">*</asp:RequiredFieldValidator>
            <asp:Label ID="lblEmail" runat="server" Text="E-mailadres "></asp:Label>
            <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail" Display="Dynamic" ErrorMessage="E-mial moet het formaat: name@domain.xyz. hebben" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators" ForeColor="Red">Fout formaat!</asp:RegularExpressionValidator><br /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbEmailOpnieuw" Display="Dynamic" ErrorMessage="Email is verplicht." ForeColor="Red" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="lblEmailOpnieuw" runat="server" Text="E-mail opnieuw invullen "></asp:Label>
            <asp:TextBox ID="tbEmailOpnieuw" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tbEmailOpnieuw" ControlToCompare="tbEmail" ErrorMessage="No Match" ForeColor="Red"></asp:CompareValidator><br /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="tbWachtwoord" Display="Dynamic" ErrorMessage="Wachtwoord is verplicht." ForeColor="Red" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="lblWachtwoord" runat="server" Text="Wachtwoord "></asp:Label>
            <asp:TextBox ID="tbWachtwoord" runat="server"></asp:TextBox><br /><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Wachtwoord is verplicht." ControlToValidate="tbWachtwoordOpnieuw" Display="Dynamic" ForeColor="Red" ValidationGroup="AllValidators">*</asp:RequiredFieldValidator>
            <asp:Label ID="lblWachtwoordOpnieuw" runat="server" Text="Wachtwoord bevestigen "></asp:Label>
            <asp:TextBox ID="tbWachtwoordOpnieuw" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="tbWachtwoordOpnieuw" ControlToCompare="tbWachtwoord" ErrorMessage="No Match" ForeColor="Red"></asp:CompareValidator><br /><br />
            <asp:CheckBox ID="cbVoorwaarden" runat="server" />
            <asp:Label ID="lblVoorwaarden" runat="server" Text="Ik ga akkoord met de voorwaarden"></asp:Label>
            <asp:CustomValidator runat="server" ID="CheckBoxRequired" EnableClientScript="true" OnServerValidate="CheckBoxRequired_ServerValidate" ForeColor="Red">Accepteer de voorwaarden om verder te gaan.</asp:CustomValidator>
            <br /><hr />
            <asp:Button ID="btnTerug" runat="server" Text="Terug" OnClick="btnTerug_Click" />
            <asp:Button ID="btnOpslaan" runat="server" Text="Opslaan en doorgaan" OnClick="btnOpslaan_Click" />
            <asp:Label ID="lblValidatie" runat="server" Text=""></asp:Label>
        </div>
    </div>
    <br />
</asp:Content>
