   M S B A M L   `   `   `  ����C  ?formProj, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:formProj.ViewsformProj.Views  5   	   9!clr-namespace:formProj.ViewModelsformProj.ViewModels  5   	   #clr-namespace:formProjformProj  5   	       formProj.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .viewsclr-namespace:formProj.Views     5   	   8
viewmodels!clr-namespace:formProj.ViewModels     5   	   (localclr-namespace:formProj     5   	     � Title$  Registration Form��5
   	   $	��350��5   	   $��Center=�5   	   $��Center=�6&    � SizeToContent$ WidthAndHeight=�5   	      PrimaryBackgroundColor#���   5   	    � 	Resources 5       �� DataType)   #formProj.ViewModels.SignUpViewModel   formProj.Views.SignUpView(   "formProj.ViewModels.LoginViewModel   formProj.Views.LoginView��%�   (��       5      *, +)(�� 2     5      *, +)�� 5   
   "  6   .R�5        5      �� 5   
   "  6   .R�5        5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $��50 �6   .+�5!   
   � $��0��6    � ColumnDefinitions 5"      �� 5#      $
��auto �5%      �� 5&      $
��auto �6#   .+�5(      �� $��
Dark Theme��6   $��20(�5)      $��
130 0 0 0 q�5*        	FontColor#���  5+      �� 5-      -   5         ��Name$ darkThemeToggle��5-      $�� ��5.      $��250 10 0 0 q�5/      $��30��50      $��50��51      $	��Top=�52      $��Right=�53       d� 	IsChecked$ FalseY�54      ��55      �� *toggleTheme+58      � 59   
   $��1��6   $��0 0 0 0q�5:      .+�5<   
   �� ��6   �� *SelectedViewModel+5=      � 5>   
   $��2��6   $��0 0 0 0q�5?      .+�5@      �� -   5        $��
switchView��5C      $��	0,0,10,10q�5A      $��Right=�5B      $��login��5E      #���  5G      $	��125��5H        ButtonColor#���  5I      ��5D      �� *
UpdateView+��5F      �� *ButtonContent+ 5L       �� 
TargetType	 �� Property
 �� Value��%^   '��       �� 5M      " ��6   .�5N      �� 	 �@��CornerRadius$
 7��69   5O      5P      5R      5S      5T      5V      