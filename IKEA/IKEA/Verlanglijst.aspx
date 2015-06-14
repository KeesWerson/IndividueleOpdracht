<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Verlanglijst.aspx.cs" Inherits="IKEA.Verlanglijst" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="CSS/Winkelwagen.css" media="screen"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3><b>Verlanglijst overzicht</b></h3>
    <br /><hr /> 
    <div id="winkelwagencontainer">
        <div class="rowcontainer">
            <div class="productomschrijving">
                <b>Product</b>
            </div>
            <div class="prijs">
                <b>Prijs per stuk</b>
            </div>
            <div class="aantal">
                <b>Aantal</b>
            </div>
            <div class="totaal">
                <b>Totaal</b>
            </div>
            <div class="verwijder">
                <b>Verwijder / Naar Winkelwagen</b>
            </div>
        </div>
        <br /><hr /><br />
        <div runat="server" id ="contentVerlanglijst">
            <!-- Voorbeeld van hoe de gegenereerde code er uit komt te zien -->
            <!--<div class="rowcontainer">
                <div class="productomschrijving">
                    <div class="afbeelding">
                        test
                    </div>
                </div>
                <div class="prijs">
                    [DB PRIJS]
                </div>
                <div class="aantal">
                    [DB AANTAL]
                </div>
                <div class="totaal">
                    [DB TOTAAL]
                </div>
                <div class="verwijder">
                    <a href="NotImplemented.aspx">Verwijder</a>
                </div>
            </div>
            <br /><hr /><br />
            <div class="rowcontainer">
                <div class="productomschrijving">
                    <div class="afbeelding">
                        test
                    </div>
                </div>
                <div class="prijs">
                    [DB PRIJS]
                </div>
                <div class="aantal">
                    [DB AANTAL]
                </div>
                <div class="totaal">
                    [DB TOTAAL]
                </div>
                <div class="verwijder">
                    <a href="NotImplemented.aspx">Verwijder</a>
                </div>
            </div>-->
        </div>
    </div>
    <br /><br /><br />
</asp:Content>
