<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PropLegisApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Contáctenos.</h3>
        <address>
            Dirección<br />
            Av. Central, Calles 15 y 17<br />
            San José, Costa Rica
        </address>

        <address>
            <strong>Soporte:</strong>   soporte<a href="mailto:Support@example.com">@example.com</a><br />
            Central telefónica<strong>: (+506) 2243-2000</strong></address>
    </main>
</asp:Content>
