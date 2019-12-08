<%@ Page Title="" Language="C#" MasterPageFile="~/HomeXQ/MasterPage.master" AutoEventWireup="true" CodeFile="checkout.aspx.cs" Inherits="Home_checkout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="tieude" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="noidung" Runat="Server">
 
     <link rel="stylesheet" type="text/css" href="styles/bootstrap4/bootstrap.min.css"/>
    <link href="plugins/fontawesome-free-5.0.1/css/fontawesome-all.css" rel="stylesheet" type="text/css"/>
    <link rel="stylesheet" type="text/css" href="styles/regular_styles.css"/>
    <link rel="stylesheet" type="text/css" href="styles/regular_responsive.css"/>

    <link rel="stylesheet" href="css/style.css" />
    <section class="ftco-section" style="margin-top:40px;">
      <div class="container">
        <div class="row justify-content-center">
          <div class="col-xl-10 ftco-animate">
			<form method="post" action="XlAddOrder.aspx" class="billing-form">
			<h3 class="mb-4 billing-heading">Billing Details</h3>
	          	<div class="row align-items-end">
	          		<div class="col-md-6">
	                <div class="form-group">
	                	<label for="name">Customer name</label>
	                  <input type="text" id="name" name="name" class="form-control" placeholder=""/>
	                </div>
	              </div>
	              <div class="col-md-6">
	                <div class="form-group">
	                	<label for="phone">Your phone</label>
	                  <input type="text" id="phone" name="phone" class="form-control" placeholder="" />
	                </div>
                </div>
                
		            <div class="col-md-6">
		            	<div class="form-group">
		            		<label for="address">Address</label>
	                  <input type="text" name="address" id="address" class="form-control" placeholder=""/>
	                </div>
		            </div>
		            <div class="w-100"></div>
		            <div class="col-md-6">
	                <div class="form-group">
	                	<label for="orders_date">Date</label>
	                  <input type="date" name="orders_date" id="orders_date" class="form-control" placeholder="" />
	                </div>
	              </div>
	              <div class="col-md-6">
	                <div class="form-group">
	                	<label for="note">Note</label>
	                  <input type="text" name="note" id="note" class="form-control" placeholder=""/>
	                </div>
                </div>
                <div class="w-100"></div>
                <div class="col-md-12">
                	<div class="form-group mt-4">
						<div class="radio">
							<label class="mr-3"><input type="radio" name="optradio"/> Create an Account? </label>
								<label><input type="radio" name="optradio"/> Ship to different address</label>
						</div>
					</div>
                     <button type="submit" class="button cart_button_checkout">Thêm</button>
                    
                </div>
	            </div>
	          </form><!-- END -->



	          
        </div>
      </div>
    </section> <!-- .section -->

</asp:Content>

