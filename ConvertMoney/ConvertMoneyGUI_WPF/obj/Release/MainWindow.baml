   M S B A M L   `   `   `  ����   ConvertMoneyGUI_WPF$    ConvertMoneyGUI_WPF.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    >d2http://schemas.microsoft.com/expression/blend/2008    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     U QWpfAnimatedGif, Version=1.0.0.0, Culture=neutral, PublicKeyToken=9e7cd3b544a090dc,gif"http://wpfanimatedgif.codeplex.com    � Title$#  Конвертер валют��$	��325��$	��325��$��Right=�$��Center=� � WindowStyle$
 None=� � 	Resources    Loading �� 	UriSource  ArrowReplace 	 Arrow�� %�   &	        &	 "     &	 I     �� $ /Resources/Loading.gif?��� $! /Resources/ArrowRaplace.png?��� $ /Resources/Arrow.jpeg?�.���  � RowDefinitions �� $��20 ��� $	��297 ��� $��0* �.+�� $��0��
�������$��0q� ��  � ColumnDefinitions �� �� $��20 ��� $��20 ��� $��20 �.+��� $��3��$��0q�$��0q�
���  ���� $��2��$��0q�$��0q�
����  ��� $��1��$��0q�$��0q�
��� ����� $#��Конвертер валют�� �� TextAlignment$ Center=�$��Center=�$��Center=�$��Arial)�$��15(�$
��Bold"�� -   $��	gdLoading��$��1��$y�	Collapsed=� �� .+��� "  WpfAnimatedGif.ImageBehavior   AnimatedSource# [  $��Center=�$��Center=�� -    �Name$ gdMain��$��1��$y�Visible=� �� $��50 ��� $��20 ��� $��35 ��� $	��145 � �� $
��134* ��� $	��25* ��� $
��158* �.+��� -   	 ��Name$	 tbActiveValuteOne��$��0��
 �� TextAlignment$
 Center=�$��Center=�$��Center=�$��Calibri)�$��20(�$
��Bold"�$��0q��� -   $	 tbActiveValuteTwo��$��2��$
 Center=�$��Center=�$��Center=�$��Calibri)�$��20(�$
��Bold"�$��0q��� #��[ $��3��$��1��$��Stretch=�$��Stretch=�$��0,0,0,33q�$��2���� -    ��Name$ LeftValuteName��$��2��$��0��$ Center=�$��Center=�$	��USD��$��18(�
���   �$��	ExtraBold"�$��24���� -   $ RightValuteName��$��2��$��2��$ Center=�$��Center=�$	��USD��$��18(�
���   �$��	ExtraBold"�$��24���� -   $ LeftChangeValute��$��3��$ Center=�$	��Top=�$#��Изменить валюту��$
��Wrap=� � Cursor$
 Hand��$��20(����#0b81ff$��	ExtraBold"�$��2��$��53���� -   $ RightChangeValute��$��3��$��2��$ Center=�$	��Top=�$#��Изменить валюту��$
��Wrap=�$
 Hand��$��20(����#0b81ff$��	ExtraBold"�$��53��� -	   $ gdSelValute��$��1��$y�	Collapsed=� ��  �� .+��� -
    ��Name$ lbListValute��
����� �