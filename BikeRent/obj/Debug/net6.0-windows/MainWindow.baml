   M S B A M L   `   `   `  ����C  ?BikeRent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BikeRentBikeRent  5   	       BikeRent.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BikeRent     5   	     � Title$  Huur een fiets!��5   	   $	��400��6!   $	��643��6.   .��5	      ]� .+�5
   
   o� $	��Top=�6   .@�5      m� $��Bestand��6   .@�5      m� -   5        $��openItem��5   ,   $��_Export��6   6<   �� 5      m� 5      -   5        $��exitItem��5   *   $��E_xit��6   6;   5      5      � 5   
   $��Bottom=�6   ��5      �� 5       �� ImageSource$ Images/BackgroundDark.png��6   .+�5      �� -   5        $��genderImage��5      $	��100��5      $��
486,46,0,0q�6!   $
��Left=�65   $	��Top=�6P   $	��128��6h   $��Uniform=�5   #   $��Images/FemaleBike.png��65   �� 5      -   5        $��electricalImage��5      $��36��5      $��
471,93,0,0q�6    $
��Left=�64   $	��Top=�6O   $��64��6g   $��Uniform=�5   '   $��Images/Electrical.png��69   �� 5         
LabelStyle#��[  6   $
��Id: ��6<   $��	38,39,0,0q�6H   �� 5      #��[  6   $��Merk: ��6<   $��	38,70,0,0q�6J   �� 5      #��[  6   $��Type: ��6<   $��
38,102,0,0q�6J   �� 5      #��[  6   $��Omschrijving: ��6<   $��
38,146,0,0q�6R   �� 5      #��[  6   $��Onderhoud: ��6<   $��
38,215,0,0q�6O   �� 5"      -   5        $��idTextBlock��5"        	DataStyle#��[ 6+   $	��001��6N   $��	65,39,0,0q�6Y   �� 5#      -   5        $��brandTextBlock��5#      #��[ 6.   $��Gazelle��6Q   $��	93,70,0,0q�6`   �� 5$      -   5        $��typeTextBlock��5$      #��[ 6-   $��
Stadsfiets��6P   $��
89,103,0,0q�6b   �� 5%      -   5        $��descriptionTextBlock��5%      #��[ 64   $��Ipsum Lorem��6W   $��163,146,0,0q�5&      $
��Wrap=�6)   $	��427��6=   $��57��6I   � 5'      -	   5        $��maintenanceProgressBar��5(   :   $
��Left=�5'      $��20��65   $��154,221,0,0q�6A   $	��Top=�5(      $	��262��6.    � Minimum$ 0Q�5)       � Maximum$	 100Q�6"    � Value$ 50Q�60   
���   �
����� �6N   �� 5*      -
   5        $��maintenanceTextBlock��5+   :   $��154,241,0,0q�5*        CaptionStyle#��[ 5+      $��300 / 10000 km��5,      $	��262��6*   �� 5-      -   5        $��rentStatusTextBlock��5-        StatusStyle#��[ 63   $&�� Verhuurd aan XXXX tot dd/mm/yyyy��6X   $��
38,305,0,0q�5.      $
��Wrap=�6(   $	��482��6<   �� 5/      -   5        $��batteryTextBlock��50   :   $��525,115,0,0q�5/      #��[ 50      $��400 Wh��51      �� 53      -   5        $��
nextButton��53   C   $��Volgende��6   $
��Left=�6(   $��525,299,0,0q�54      $	��Top=�6&   $	��100��6>   $��40��6J   $��18(�6V   55      �� 56      -   5        $��rentOrReturnButton��56   ?   $
��Huur��6   $
��Left=�6$   $��420,299,0,0q�57      $	��Top=�6&   $	��100��6>   $��40��6J   $��18(�6V   59      5:      5;      