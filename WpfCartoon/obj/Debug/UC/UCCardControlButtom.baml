   M S B A M L   `   `   `  ����E  AWpfCartoon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfCartoon.UCWpfCartoon.UC  5      '    !WpfCartoon.UC.UCCardControlButtom   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:WpfCartoon.UC     5      -   5          >�Name$  MyUserControl��5      $	��300��6%   $	��200��62   .��5	      �� $��0q�6    J� Effect 5
   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 20Q�6      Color$
 Gray��6/      	Direction$	 -90Q�6<      ShadowDepth$ 10Q�6L   6_   ��5   
   
� 5       
� GradientOrigin$ 0.5,0.5&�6"    
� Center$ 0.5,0.5&�6;    
� RadiusX$
 0.75Q�6L   	 
� RadiusY$
	 0.65Q�6[   .��5      � 
 � Color$
 DimGray��6    � Offset$ 0Q�6/   � 5      $
 Black��6   $ 1Q�6-   5      ._�5   
   �  � RowDefinitions 5      �� 5      6"   �� 5      6"   .+�5      �� $��0��6   $��Arial)�6`   
�������$	��150(�6�   $
��Bold"�6�   $��Center=�6�   $	��Top=�6�   $��0,65,0,2q�6�   ��6%   ��  �� ElementName$ MyUserControl�� �� Path$ 
BottomText� 5        5      $ 10Q�6'   $ Black��67   $	 -90Q�6E   $ 2Q�6U   6g   5      �� 5      $��1��6   $��Arial)�6`   
�������$	��150(�6�   $
��Bold"�6�   $��Center=�6�   $��Bottom=�6�   $��0,0,0,65q�6�   ��6%   �� $ MyUserControl��$ 
BottomText� 5        5      $ 10Q�6'   $ Black��67   $	 -90Q�6E   $ 2Q�6U   6g   5!      5"      5#      5$      