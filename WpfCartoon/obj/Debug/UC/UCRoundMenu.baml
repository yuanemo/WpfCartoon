   M S B A M L   `   `   `  ����E  AWpfCartoon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfCartoon.UCWpfCartoon.UC  5          WpfCartoon.UC.UCRoundMenu   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfCartoon.UC     5        � 	Resources  5	         stbShow �� 
TargetName �� TargetProperty g� Duration W� From	 W� To g� FillBehavior  stbHide��%x  &	        &	 2    �� 5
   
   .��5      W� $ myEllipseGeometry��6   $ RadiusX�5      $ 0:0:0.5D�5      $ 0X�61   $	 200X�6:   $ HoldEnd=�5      W� 5      $ myEllipseGeometry��6   $ RadiusY�5      $ 0:0:0.5D�5      $ 0X�61   $	 200X�6:   $ HoldEnd=�5      5      �� 5   
   .��5      W� $ myEllipseGeometry��6   $ RadiusX�5      $ 0:0:0.5D�5      $	 200X�61   $ 0X�6<   $ HoldEnd=�5      W� 5      $ myEllipseGeometry��6   $ RadiusY�5      $ 0:0:0.5D�5      $	 200X�61   $ 0X�6<   $ HoldEnd=�5      5      5      .��5      �� -   5         ��Name$ 
mainCanvas��5       � Cursor$
 Hand��6!   }�. .+�5    
   �� -   5        $ sectorCanvas��5       .+�5!      $   WpfCartoon.UC.UCCircularSector  	   BackgroundColor$	 Transparent��6%   
   DisplayImage$
 ../Images/img1.png��6C   5"        5#      $	 Transparent��6%   $
 \Images\img2.png��6C   z�5$      �� 5%       �� Angle$ 45Q�6&    �� CenterX$	 200Q�61    �� CenterY$	 200Q�6?   6O   5'        5(      $	 #F44E4E��6%   $
 /Images/img3.png��6?   z�5)      �� 5*      $ 90Q�6&   $	 200Q�61   $	 200Q�6?   6O   5,        5-      $	 #F45757��6%   $
 ..\Images/img4.png��6?   z�5.      �� 5/      $	 135Q�6&   $	 200Q�62   $	 200Q�6@   6P   51      52      F� 53   
   ��54      @� 55      -   5        myEllipseGeometry�� @� RadiusX$ 0Q�55   =    @� RadiusY$ 0Q�6I    @� Center$ 200,200&�6U   6h   57      � 58   
   -   5         �Name$ 
bottomGrid��58       �� Left$	 150��6#   
 �� Top$	 150��65   .+�59      F� %����        � ��    � �� ��	
������� �� Stretch$
 Fill=�6D   $	��100��6S   $��50��6_   �� 5:      -   5         ��Name$ bottomTB��5:      $��+��6*   $��38(�63   $��Center=�6A   $��Center=�6^   6{   5;      5<      5=      