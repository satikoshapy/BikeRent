   M S B A M L   `   `   `  ����C  ?BikeRent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BikeRentBikeRent  5   	       BikeRent.RentalWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BikeRent     5   	     � Title$  Verhuur��5   	   $	��450��6   $	��476��6&   .��5	      � ��5
   
   �� 5       �� ImageSource$  Images/BackgroundLight.png��6    j� Stretch$ UniformToFill=�6B   .+�5   
   �� -   5        $��titleTextBlock��5         
TitleStyle#��[  5      $��Fiets Id - Brand��68   $��	38,39,0,0q�5      5      �� 5   
     DarkLabelStyle#��[ 6   $��
38,108,0,0q�6<   $��
Startdatum��5      �� 5   
   #��[ 6   $��
38,161,0,0q�6<   $��Aantal dagen��5      �� 5   
   #��[ 6   $��
38,219,0,0q�6<   $��
Naam klant��5      �� 5   
   #��[ 6   $��
38,278,0,0q�6<   $��Totaal (EUR)��5      �� 5   
   -   5        $��startDateTextBox��5        
EntryStyle#��[ 5      $��201,108,0,0q�66   5      �� 5   
   -   5        $��
daysSlider��5   6   $
��Left=�5   8   $��201,167,0,0q�6S   $	��Top=�6h   $	��200��5       � Minimum$ 1Q�6    � Maximum$ 14Q�6)    �� TickPlacement$ BottomRight=�5       �� IsSnapToTickEnabled$
 True��6-   �� 5   
   -   5        $��daysTextBlock��5        DarkDataStyle#��[ 5      $��419,161,0,0q�6;   $��XX��6P   5      �� 5    
   -   5        $��customerTextBox��5!      #��[ 5       $��201,219,0,0q�66   5!      �� 5"   
   -   5        $��totalTextBlock��5#      #��[ 5"      $��201,278,0,0q�6;   $��XX.XX ��6P   5#      �� 5$   
   -   5        $��kmTextBlock��5%   %   #��[ 5$      $��
38,326,0,0q�6<   $��	Aantal km��5%      6%   �� 5&   
   -   5        $��	kmTextBox��5'      #��[ 5&      $��201,323,0,0q�66   5'      �� 5(   
   -	   5        $��submitButton��5)        ButtonStyle#��[ 5(      $��Button��66   $��301,369,0,0q�6G   5)   %   5*      5+      