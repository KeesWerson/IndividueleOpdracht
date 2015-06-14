<%@ Page Title="" Language="C#" MasterPageFile="~/IKEA.Master" AutoEventWireup="true" CodeBehind="Sitebeheer.aspx.cs" Inherits="IKEA.Sitebeheer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="tbPath" runat="server"></asp:TextBox>
    <asp:Button ID="btnBrowse" runat="server" Text="Browse..."/><br /><br />
</asp:Content>
