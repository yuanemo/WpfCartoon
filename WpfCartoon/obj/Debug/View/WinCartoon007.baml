   M S B A M L   `   `   `  ����E  AWpfCartoon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfCartoon.ViewWpfCartoon.View  5   	   #    WpfCartoon.View.WinCartoon007   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfCartoon.View     5   	     � Title$  SpotlightExample��5   	   $	��450��5	   	   $	��800��6   
�������$��Arial Black)�5
   	   $	��120(�6#    � UseLayoutRounding .  � WindowStartupLocation$ CenterScreen=�5   	   .��5      �� -   5         ��Name$ containerCanvas��5      $	��100q�6&   .+�5   
   �� $��Geometry��6   
����� �6$   �� 5   
   -   5         ��Name$ GeometryText��5      $��Geometry��6*   
��� ���6Q   F� 5   
   -   5        $��myPathShape��5      
������ ��5      @� 5      -   5        MyEllipseGeometry�� @� Center$
 0,70&�5   =    @� RadiusX$	 100Q�6K    @� RadiusY$	 100Q�6Y    � Triggers 5      :� 5      	 :� RoutedEvent$	 Path.Loaded��6   .[�5      �� .��5      �� .��5      ,� 
 �� 
TargetName$
 MyEllipseGeometry��6.    �� TargetProperty$ Center�6X    ,� From$
 0,70X�6{   	 ,� To$ 650,70X�6�    g� Duration$ 0:0:5D�6�    g� AutoReverse .  g� RepeatBehavior$ Forever��6�   5      5      5      5      5      5      