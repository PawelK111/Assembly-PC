   M S B A M L   `   `   `  ����E  AAssemblyPC, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:AssemblyPC
AssemblyPC  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       AssemblyPC.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:AssemblyPC     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      � .+�5   
   �� -   5        $��	HDD / SSD��5      $��10,10,690,376q�6%   $��30��6<   $��80��6H   $	��Top=�6S   6k   �� 5   
   -   5        $	��GPU��5      $��107,10,586,376q�6   $��30��67   $��80��6C   $	��Top=�6N   6f   �� 5   
   -   5        $	��CPU��5      $��211,10,487,376q�6   $��30��67   $��80��6C   $	��Top=�6N   6f   �� 5   
   -   5        $��MotherBoard��5      $��407,12,295,377q�6'   $��30��6?   $��80��6K   $	��Top=�6V   6n   �� 5   
   -   5        $��Cover��5      $��502,12,200,377q�6!   $��30��69   $��80��6E   $	��Top=�6P   6h   �� 5   
   -   5        $	��RAM��5      $��597,12,105,377q�6   $��30��67   $��80��6C   $	��Top=�6N   6f   �� 5   
   -   5        $��Power supply��5      $��692,12,10,377q�6(   $��30��6?   $��80��6K   $	��Top=�6V   6n   �� 5   
   -   5        $��Cooling��5      $��310,10,388,376q�6#   $��30��6;   $��80��6G   $	��Top=�6R   6j   �� 5   
   -	   5        $��Add Component to DB��5      $
��Left=�6/   $��
16,379,0,0q�6J   $	��Top=�6^   $	��163��6v   $��30��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ ListOfComponent��5      $
��Left=�6,   $	��244��6G   $	��Top=�6T   $	��575��6l   $��
112,56,0,0q�6x      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 61   6>     5      $ 	Producent��6%   $	 100 68   6F     5      $ Model��6%   $	 100 64   6B     5      $
 Cost��6%   $	 100 63   6A     5      $ Date of production��6%   $	 150 6A   6O     5      $ 	More info��6%   $	 100 68   6F   5      5       5!      