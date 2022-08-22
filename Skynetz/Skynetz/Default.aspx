<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Skynetz._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Skynetz</h1>
    </div>

    <form>
    <div class="form-group">
      <label class="control-label" for="inputSuccess1">Código Origem e Destino</label>
        <asp:DropDownList ID="DropDownListCodigoOrigemEDestino" class="form-control" runat="server"></asp:DropDownList>
    </div>
    <div class="form-group">
      <label class="control-label" for="inputError1">Tempo da ligação em minutos</label>
        <asp:TextBox ID="TextBoxTempoLigacao" type="text" class="form-control" runat="server"></asp:TextBox>  
    </div>
    <div class="form-group">
      <label class="control-label" for="inputError1">Plano</label>
        <asp:DropDownList ID="DropDownListPlano" class="form-control" runat="server"></asp:DropDownList>
    </div>
    <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular Valor" />
    </form>
    <hr>
    <div class="row">
        <div class="col-md-4">
            <h2>Tarifa fixa por minuto</h2>
            <div class="panel panel-default">
              <!-- Default panel contents -->
              <div class="panel-heading">Tarifa fixa por minuto</div>
              <!-- Table -->
              <table class="table">
                <thead>
                    <tr>
                        <th>Origem</th>
                        <th>Destino</th>
                        <th>R$/min</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>011</td>
                        <td>016</td>
                        <td>1,90</td>
                    </tr>
                    <tr>
                        <td>016</td>
                        <td>011</td>
                        <td>2,90</td>
                    </tr>
                </tbody>
              </table>
            </div>
        </div>
        <div class="col-md-8">
            <h2>Histórico de Preços</h2>
            <div class="panel panel-default">
              <!-- Default panel contents -->
              <div class="panel-heading">Verifique os custo com e sem o plano FaleMais</div>

                <asp:Repeater ID="rpt" runat="server" >
                    <HeaderTemplate>
                        <table class="table">
                            <thead>
                                <tr>
                                    <th>Origem</th>
                                    <th>Destino</th>
                                    <th>Tempo</th>
                                    <th>Plano FaleMais</th>
                                    <th>Com FaleMais</th>
                                    <th>Sem FaleMais</th>
                                </tr>
                            </thead>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tbody>
                        <tr>
                            <td><asp:Label ID="Text1" runat="server" Text='<%#Eval("Origem") %>' autocomplete="off"></asp:Label></td>
                            <td><asp:Label ID="Text2" runat="server" Text='<%#Eval("Destino") %>' autocomplete="off"></asp:Label></td>
                            <td><asp:Label ID="Text3" runat="server" Text='<%#Eval("Tempo") %>' autocomplete="off"></asp:Label></td>
                            <td><asp:Label ID="Text4" runat="server" Text='<%#Eval("Plano") %>' autocomplete="off"></asp:Label></td>
                            <td><asp:Label ID="Text5" runat="server" Text='<%#Eval("ComFaleMais") %>' autocomplete="off"></asp:Label></td>
                            <td><asp:Label ID="Text6" runat="server" Text='<%#Eval("SemFaleMais") %>' autocomplete="off"></asp:Label></td>
                        </tr>
                        </tbody>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>

</asp:Content>
