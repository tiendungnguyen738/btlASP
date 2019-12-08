<%@ Page Title="" Language="C#" MasterPageFile="~/HomeXQ/MasterPage.master" AutoEventWireup="true" CodeFile="cart.aspx.cs" Inherits="Home_cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="noidung" Runat="Server">
    <link rel="stylesheet" type="text/css" href="styles/product_styles.css" />
    <link rel="stylesheet" type="text/css" href="styles/product_responsive.css" />
    <link rel="stylesheet" type="text/css" href="styles/cart_styles.css" />
    <link rel="stylesheet" type="text/css" href="styles/cart_responsive.css" />
    <div class="cart_section">
		<div class="container">
			<div class="row">
				<div class="col-lg-10 offset-lg-1">
					<div class="cart_container">
					    <form id="form11" runat="server">
                            <div>
                                <%
                                    
                                    hienthi();
                                    %>
                            </div>
					    </form>
					</div>
				</div>
			</div>
            <section class="ftco-section hide" style="margin-top:40px;display: none;" id="checkout">
              <div class="container">
                <div class="row justify-content-center">
                  <div class="col-xl-10 ftco-animate">
			        <form method="post" action="XlAddOrder.aspx" class="billing-form">
			        <h3 class="mb-4 billing-heading">Hóa đơn</h3>
	          	        <div class="row align-items-end">
	          		        <div class="col-md-6">
	                        <div class="form-group">
	                	        <label for="name">Tên khách hàng</label>
	                          <input type="text" id="name" name="name" value="<%Response.Write(Session["fullname"].ToString());%>" class="form-control name" placeholder=""/>
	                        </div>
	                      </div>
	                      <div class="col-md-6">
	                        <div class="form-group">
	                	        <label for="phone">Số điện thoại</label>
	                          <input type="text" id="phone" name="phone" value="<%Response.Write(Session["phone"].ToString());%>" class="form-control phone" placeholder="" />
	                        </div>
                        </div>
                
		                    <div class="col-md-6">
		            	        <div class="form-group">
		            		        <label for="address">Địa chỉ</label>
	                          <input type="text" name="address" value="<%Response.Write(Session["address"].ToString());%>" id="address" class="form-control address" placeholder=""/>
	                        </div>
		                    </div>
		                    <div class="w-100"></div>
		                    <div class="col-md-6">
	                        <div class="form-group">
	                	        <label for="orders_date">Ngày</label>
	                          <input type="date" name="orders_date" id="orders_date" class="form-control" placeholder="" />
	                        </div>
	                      </div>
	                      <div class="col-md-6">
	                        <div class="form-group">
	                	        <label for="note">Ghi chú</label>
	                          <input type="text" name="note" id="note" class="form-control note" placeholder=""/>
	                        </div>
                        </div>
                        <div class="w-100"></div>
                        <div class="col-md-12">
                	        <div class="form-group mt-4">
						        <div class="radio">
							        <label class="mr-3"><input type="radio" name="optradio" class="show1"/> Tùy chỉnh </label>
								        <label><input type="radio" name="optradio" class="hide2"/> Mua tặng</label>
						        </div>
					        </div>
                             <button type="submit" class="button cart_button_checkout" onclick="return alert('Đặt hàng thành công.')">Đặt hàng</button>
                    
                        </div>
	                    </div>
	                  </form><!-- END -->



	            </div>
                </div>
              </div>
            </section> <!-- .section -->

            <section class="ftco-section" style="margin-top:40px;display: none;" id="Section1">
              <div class="container">
                <div class="row justify-content-center">
                  <div class="col-xl-10 ftco-animate">
			        <form method="post" action="XlAddOrder.aspx" class="billing-form">
			        <h3 class="mb-4 billing-heading">Hóa đơn</h3>
	          	        <div class="row align-items-end">
	          		        <div class="col-md-6">
	                        <div class="form-group">
	                	        <label for="name">Tên khách hàng</label>
	                          <input type="text" id="name1" name="name" value="<%Response.Write(Session["fullname"].ToString());%>" class="form-control name1" placeholder=""/>
	                        </div>
	                      </div>
	                      <div class="col-md-6">
	                        <div class="form-group">
	                	        <label for="phone">Số điện thoại</label>
	                          <input type="text" id="phone2" name="phone" value="<%Response.Write(Session["phone"].ToString());%>" class="form-control phone1" placeholder="" />
	                        </div>
                        </div>
                
		                    <div class="col-md-6">
		            	        <div class="form-group">
		            		        <label for="address">Địa chỉ</label>
	                          <input type="text" name="address" value="<%Response.Write(Session["address"].ToString());%>" id="address1" class="form-control address1" placeholder=""/>
	                        </div>
		                    </div>
		                    <div class="w-100"></div>
		                    <div class="col-md-6">
	                        <div class="form-group">
	                	        <label for="orders_date">Ngày</label>
	                          <input type="date" name="orders_date" id="Date1" class="form-control" placeholder="" />
	                        </div>
	                      </div>
	                      <div class="col-md-6">
	                        <div class="form-group">
	                	        <label for="note">Ghi chú</label>
	                          <input type="text" name="note" id="Text4" class="form-control note" placeholder=""/>
	                        </div>
                        </div>
                        <div class="w-100"></div>
                        <div class="col-md-12">
                	        <div class="form-group mt-4">
						        <div class="radio">
							        <label class="mr-3"><input type="radio" name="optradio" class="show1"/> Tùy chỉnh </label>
								        <label><input type="radio" name="optradio" class="hide2"/> Mua tặng</label>
						        </div>
					        </div>
                             <button type="submit" class="button cart_button_checkout">Đặt hàng</button>
                    
                        </div>
	                    </div>
	                  </form><!-- END -->



	            </div>
                </div>
              </div>
            </section> <!-- .section -->
		</div>
	</div>
</asp:Content>

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 