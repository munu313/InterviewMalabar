<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Interview.aspx.cs" Inherits="InterviewMalabar.Interview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        </br>
        </br>
        </br>
        <div>
            <div class="container">
                <div class="panel panel-primary">
                    <div class="panel-heading">Panel with panel-primary class</div>
                    <div class="panel-body">

                        <div class="form-group row">
                            <label for="staticEmail" class="col-md-2 col-form-label">Name Of Employee</label>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtname" runat="server" class="form-control"></asp:TextBox>
                            </div>

                            <label for="staticEmail" class="col-md-2 col-form-label">Phone Number</label>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtphone" runat="server" class="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group row">
                            <label for="staticEmail" class="col-md-2 col-form-label">Address</label>
                            <div class="col-md-4">
                                <asp:TextBox ID="txtaddress" runat="server" class="form-control" TextMode="MultiLine"></asp:TextBox>
                            </div>
                            <div class="col-md-4">
                                <asp:Button ID="btnadd" runat="server" Text="Add" class="btn btn-success" OnClick="btnadd_Click"></asp:Button>
                            </div>
                        </div>

                        <div class="form-group row">
                            <div class="col-md-offset-2 col-md-8">
                                <asp:GridView ID="GridView1" runat="server" CssClass="Grid" AutoGenerateColumns="False"
                                    EmptyDataText="No records has been added." CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting"
                                    OnRowEditing="GridView1_RowEditing">
                                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                                    <Columns>
                                        <asp:BoundField DataField="Employeename" HeaderText="Name" ItemStyle-Width="120">
                                            <ItemStyle Width="120px"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="EmployeeePhone" HeaderText="Phone" ItemStyle-Width="120">
                                            <ItemStyle Width="120px"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:BoundField DataField="EmployeeeAddress" HeaderText="Address" ItemStyle-Width="120">
                                            <ItemStyle Width="120px"></ItemStyle>
                                        </asp:BoundField>
                                        <asp:CommandField ShowEditButton="True" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                    </Columns>
                                    <EditRowStyle BackColor="#999999" />
                                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                                </asp:GridView>
                            </div>
                            </div>

                        <div class="col-md-offset-3 col-md-1">
                            <asp:Button ID="btnsubmit" runat="server" Text="Submit    " class="btn btn-success" OnClick="btnsubmit_Click" />
                        </div>
                         <div class="col-md-1">
                            <asp:Button ID="btnread" runat="server" Text="Read Data" class="btn btn-success" OnClick="btnread_Click"  />
                        </div>
                        

                </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
