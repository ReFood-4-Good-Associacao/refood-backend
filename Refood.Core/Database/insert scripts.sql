
INSERT INTO R_Supplier VALUES('Continente','1','11111111','email1@refood.pt','0','0','Continente','http://google.com',null,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_Supplier VALUES('Pingo Doce','1','2222222','email2@refood.pt','0','0','Pingo Doce','http://google.com',null,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_Supplier VALUES('Cantina','1','333333333','email3@refood.pt','0','0','Cantina','http://google.com',null,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_Supplier VALUES('Restaurante Laurentina','1','444444444','email4@refood.pt','0','0','Restaurante Laurentina','http://google.com',null,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_Supplier VALUES('Tasca','2','555555555','email5@refood.pt','0','0','Tasca','http://google.com',null,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_Supplier VALUES('Café','2','6666666666','email6@refood.pt','0','0','Café','http://google.com',null,0,1,GETDATE(),1,GETDATE())

INSERT INTO R_SupplierType VALUES('Restaurant','Restaurant',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_SupplierType VALUES('Hotel','Hotel',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_SupplierType VALUES('Institution','Institution',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_SupplierType VALUES('Supermarket','Supermarket',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_SupplierType VALUES('Bakery','Bakery',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_SupplierType VALUES('Farm','Farm',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_SupplierType VALUES('PrivateDoner','PrivateDoner',1,0,1,GETDATE(),1,GETDATE())

INSERT INTO R_TaskType VALUES('Packaging','Packaging',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_TaskType VALUES('Pickup Route','Pickup Route',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_TaskType VALUES('Delivery Route','Delivery Route',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_TaskType VALUES('Management','Management',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_TaskType VALUES('Event','Event',1,0,1,GETDATE(),1,GETDATE())

INSERT INTO R_VehicleType VALUES('Foot','Foot',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_VehicleType VALUES('Car','Car',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_VehicleType VALUES('Van','Van',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_VehicleType VALUES('Motorbike','Motorbike',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_VehicleType VALUES('Bicycle','Bicycle',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_VehicleType VALUES('Drone','Drone',1,0,1,GETDATE(),1,GETDATE())

INSERT INTO R_EnergySource VALUES('None','None',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_EnergySource VALUES('Manual','Manual',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_EnergySource VALUES('Electric','Electric',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_EnergySource VALUES('Diesel','Diesel',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_EnergySource VALUES('Gasoline','Gasoline',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_EnergySource VALUES('Gas','Gas',1,0,1,GETDATE(),1,GETDATE())

INSERT INTO R_DeliveryReportMessageType VALUES('Message for delivery team','Message for delivery team',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_DeliveryReportMessageType VALUES('Problem with delivery','Problem with delivery',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_DeliveryReportMessageType VALUES('New Beneficiary','New Beneficiary',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_DeliveryReportMessageType VALUES('Now Show Beneficiary','Now Show Beneficiary',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_DeliveryReportMessageType VALUES('Dropout','Dropout',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_DeliveryReportMessageType VALUES('Suggestion','Suggestion',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_DeliveryReportMessageType VALUES('Additional Information','Additional Information',1,0,1,GETDATE(),1,GETDATE())

INSERT INTO R_ContributionType VALUES('Service','Service',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_ContributionType VALUES('Equipment','Equipment',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_ContributionType VALUES('Money','Money',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_ContributionType VALUES('Hours','Hours',1,0,1,GETDATE(),1,GETDATE())

INSERT INTO R_ContributionChannel VALUES('SMS','SMS',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_ContributionChannel VALUES('IRS','IRS',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_ContributionChannel VALUES('Physical','Physical',1,0,1,GETDATE(),1,GETDATE())
INSERT INTO R_ContributionChannel VALUES('Bank Transfer','Bank Transfer',1,0,1,GETDATE(),1,GETDATE())



