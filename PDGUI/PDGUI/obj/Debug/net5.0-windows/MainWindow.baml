   M S B A M L   `   `   `  ����@  <PDGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PDGUIPDGUI  5   	       PDGUI.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:PDGUI     5   	     � Title$  
MainWindow��5   	   $	��460��6   $	��800��6)   $	��460��65   $	��460��6E   $	��800��6U   $	��800��6d    � WindowStartupLocation$ CenterScreen=�5	      .��5      � $	��800��6   $	��450��6   $	��800��6$   $	��800��63   $	��450��6B   $	��450��6R    � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ browseImposterSetBtn��5      $��Browse��6/   $
��Left=�6@   $��629,131,0,0q�6[   $	��Top=�6p   $��78��6�   $��24��6�   
���   �
�������$
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ 	impTxtFld��5      $
��Left=�6%   $��223,131,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��390��6�   $��24��6�   �� 5   
   -   5         ��Name$ 	textBlock��5      $
��Left=�6'   $��-188,96,0,0q�6B   $��	TextBlock��6W   $
��Wrap=�6h   $	��Top=�6|   �� 5   
   -   5         ��Name$ label��5      $��Configuration��6   $��Center=�67   $	��Top=�6T   ���	#FF81B9B9$��60��6�   $	��800��6�   $��36(�6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   �� 5   
   -   5        $ impLbl��5      $��Imposter Set��6    $
��Left=�67   $��
24,127,0,0q�6R   $	��Top=�6f   $��Right=�6~   $	��150��6�   $��16(�6�   �� 5   
   -   5        $ browseTestCollectionBtn��5      $��Browse��62   $
��Left=�6C   $��629,194,0,0q�6^   $	��Top=�6s   $��78��6�   $��24��6�   
���   �
�������$
��Bold"�6�   6�   �� 5   
   -   5        $ testColTxtFld��5      $
��Left=�6)   $��223,194,0,0q�6D   $
 Wrap=�6Y   $	��Top=�6m   $	��390��6�   $��24��6�   �� 5   
   -   5        $ 
testColLbl��5      $��Test Collection��6$   $
��Left=�6>   $��
24,190,0,0q�6Y   $	��Top=�6m   $��Right=�6�   $	��150��6�   $��16(�6�   �� 5   
   -	   5        $ postTrainEpochLbl��5      $��Post-Training Epoch��6+   $
��Left=�6I   $��
24,261,0,0q�6d   $	��Top=�6x   $��Right=�6�   $��16(�6�   �� 5   
   -
   5        	 ��Name$	 epochComboBox��5      $
��Left=�6*   $��223,265,0,0q�6E   $	��Top=�6Z   $	��189��6r   $��24��6~   .@�5      �� $��3��6   �� 5      $��4��6   �� 5      $��5��6   �� 5      $��6��6   �� 5       $��7��6   �� 5!      $��8��6   �� 5"      $��9��6   �� 5#      $��10��6   5$      �� 5%   
   -   5        $
 Next��5%      $
��NEXT��6   $
��Left=�6.   $��695,377,0,0q�6I   $	��Top=�6^   $��37��6v   $��81��6�   ���	#FF81B9B9$
��Bold"�6�   6�   5'      5(      