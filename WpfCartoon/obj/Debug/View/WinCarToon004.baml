   M S B A M L   `   `   `  ����E  AWpfCartoon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfCartoon.ViewWpfCartoon.View  5   	   #    WpfCartoon.View.WinCarToon004   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:WpfCartoon.View     5   	     � Title$  粒子效果��5   	   $	��450��5	   	   $	��800��6    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�62   .��5      � -   5         �Name$ mainGrid��5      
���   �.+�5   
   '� -   5        $��World��5       '� Camera 5      P� 5       � Position$ 0,0,501�6%    � LookDirection$ 0,0,-505�67    � UpDirection$ 0,1,05�6O   	 P� Width$		 128Q�6c   x�5      g� 5      
 g� Content
 5      h� 5      -   5        WorldModels��.��5      ��  �� Color$ 	#FFFFFFFF��6+   5      5      5      ]� 5   
   ���	#01000000.+�5      �� -   5        $��FrameRateLabel��5   )   $y�Visible=�6   $	��Top=�6?   
��� ���$��FPS: 0��6h   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      	� -   5         	�Name$ rdoSnowflake��5      $��雪花��64   
������� � Cursor$
 Hand��6T    d� 	IsChecked$
 TrueY�6b   6�   	� 5      -   5        $ rdoNeonLights��5      $��霓虹��65   
���  ��$
 Hand��6S   6�   5      5       5!      5"      