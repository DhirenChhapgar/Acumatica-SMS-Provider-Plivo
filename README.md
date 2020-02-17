[![Project Status](http://opensource.box.com/badges/active.svg)](http://opensource.box.com/badges)

Customization to include Plivo as SMS Provider in Acumatica ERP
==================================
An extension that allows to use Plivo as SMS provider to send SMS notification from Acumatica.

### Prerequisites
* Acumatica 2019 R2 or higher

Quick Start
-----------

### Installation

##### Install the customization deployment package
1. Download PXSMSProviderPlivoExtPkg.zip from this repository
2. In your Acumatica ERP instance, navigate to System -> Customization -> Customization Projects (SM204505), import PXSMSProviderPlivoExtPkg.zip as a customization project
3. Publish the customization project.

### Usage

1.	Create Plivo Account and get your Plivo Phone Number (For more information [Click here](https://console.plivo.com/accounts/register/
))
2.	You can access AUTH ID and AUTH TOKEN on your Account Dashboard in Plivo Console.
3.	In Acumatica site, Go to System -> Management -> Configure -> Voice Provider (SM203535) screen and select PX.SmsProvider.Plivo.PlivoSmsProvider as Plug-In (type)
4.	Specify Plug-In Parameters.

    ![Screenshot](/_ReadMeImages/Image1.png)

5.  Now this Plivo-based provider can be used for sending access code during two-factor authentication and business notifications in Acumatica via SMS.

Known Issues
------------
None at the moment

## Copyright and License

This component is licensed under the MIT License, a copy of which is available online [here](LICENSE)
