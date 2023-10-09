<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PropuestaForm.aspx.cs" Inherits="PropLegisApp.PropuestaForm" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <main>

        <script type="text/javascript">
            function JSAlertaMsg() {
                alert("Registro guardado satisfactoriamente")
            }
        </script>

        <section class="row">
            <h1>Registro de Propuestas Legislativas</h1>
            <p class="lead">Digite su propuesta legislativa. Proporcione la información requerida en los siguientes campos.</p>
        </section>

        <section>
            <script type="text/javascript">
                function validaTipoID() {
                    var rbtnChecked = document.getElementById("rbtnTipoID");
                    if (rbtnChecked.val()=="Nacional")
                }
            </script>
            <div class="col" style="margin-top:15px;">
                <asp:Label ID="lblID" runat="server" Text="Seleccione tipo de identificación:" Font-Bold="True"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvTipoID" runat="server" ControlToValidate="rbtnTipoID" ErrorMessage="Debe seleccionar tipo de ID"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:RadioButtonList ID="rbtnTipoID" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="rbtnTipoID_SelectedIndexChanged">
                    <asp:ListItem Selected="True">Nacional</asp:ListItem>
                    <asp:ListItem>Residente</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:Label ID="lblIdentificacion" runat="server" Text="Ingrese identificación:" Font-Bold="True"></asp:Label>
                <asp:RegularExpressionValidator ID="revTipoID" runat="server" ControlToValidate="txtID" ValidationExpression="^[1-9]-\d{4}-\d{4}$" ErrorMessage="Ingrese identificación en formato correcto"></asp:RegularExpressionValidator>
                <asp:TextBox ID="txtID" runat="server" Width="200px" CssClass="form-control"></asp:TextBox>
                <br />
            </div>
        </section>

        <section>
            <div class="col" style="margin-top:15px;">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre Completo:" Font-Bold="True"></asp:Label>
                <asp:RequiredFieldValidator ID="rfv_Nombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="* Campo obligatorio" ValidationGroup="allvalidation"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtNombre" runat="server" ToolTip="Ingrese su nombre completo" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Label ID="lblApellidos" runat="server" Text="Apellidos:" Font-Bold="True"></asp:Label>
                <asp:RequiredFieldValidator ID="rfvApellidos" runat="server" ControlToValidate="txtApellidos" ErrorMessage="* Campo obligatorio" ToolTip="Ingrese sus dos apellidos"></asp:RequiredFieldValidator>  
                <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </section>

        <section>
             <div class="col" style="margin-top:15px;">
                 <br />
                 <asp:Label ID="lblContacto" runat="server" Text="Número telefonico:" Font-Bold="True"></asp:Label>
                 <asp:TextBox ID="txtContacto" runat="server" Width="150px" CssClass="form-control" style="display:inline-block"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="revContacto" runat="server" ControlToValidate="txtContacto" 
                     ValidationExpression="^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{2}$"
                     ErrorMessage="Ingrese telefono en formato correcto"></asp:RegularExpressionValidator>
                 <asp:Label ID="lblEmail" runat="server" Text="Correo Electrónico:" Font-Bold="True"></asp:Label>
                 <asp:TextBox ID="txtEmail" runat="server" Width="150px" CssClass="form-control" style="display:inline-block"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ValidationExpression="^\S+@\S+$" ErrorMessage="Formato e-mail incorrecto"></asp:RegularExpressionValidator>
             </div>
        </section>

        <section>
            <div class="col" style="margin-top:15px;">
                
                <asp:Label ID="lblProvincia" runat="server" Text="Provincia:" Font-Bold="True"></asp:Label>
                <asp:DropDownList ID="ddlProvincia" runat="server" Width="150px" CssClass="form-control" style="display:inline-block" AutoPostBack="True" OnSelectedIndexChanged="on_dllProvincia_Changed">
                    <asp:ListItem>Seleccione</asp:ListItem>
                    <asp:ListItem>San José</asp:ListItem>
                    <asp:ListItem>Heredia</asp:ListItem>
                    <asp:ListItem>Alajuela</asp:ListItem>
                    <asp:ListItem>Cartago</asp:ListItem>
                    <asp:ListItem>Puntarenas</asp:ListItem>
                    <asp:ListItem>Guanacaste</asp:ListItem>
                    <asp:ListItem>Limón</asp:ListItem>
                </asp:DropDownList>

                <asp:Label ID="lblCanton" runat="server" Text="Cantón:" Font-Bold="True"></asp:Label>
                <asp:DropDownList ID="ddlCanton" runat="server" Width="150px" CssClass="form-control" style="display:inline-block">
                </asp:DropDownList>
                
            </div>
        </section>

        <section>
            <div class="col">
                <br />
                <asp:Label ID="lblPropuesta" runat="server" Text="Ingrese su propuesta:" ToolTip="200 caracteres máximo" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="txtPropuesta" runat="server" TextMode="MultiLine" Width="540px" CssClass="form-control" MaxLength="200" Rows="3"></asp:TextBox>
                <br />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" OnClick="OnLimpiar_Clicked" />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="OnClick" />
            </div>
        </section>
       
    </main>
    </section>
</asp:Content>

