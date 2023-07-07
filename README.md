 # Kinect_UnityChan
Kinect v2を使用してモーションキャプチャーを作る(アバターはUnityちゃんを使用)＿

参考サイト　http://www.buildinsider.net/small/bookkinectv2/0703

windowsでkinect v2を使うにはKinect for Windows SDK 2.0が必要
https://learn.microsoft.com/ja-jp/windows/apps/design/devices/kinect-for-windows

ここからSDKとkinectViewなどのkinectをWindows、そしてunityで使うためのツールが手に入る。ここにあるコードはUnityで使えるようにkinectViewのコードを改変、追加したものである。

注意!!

自分はkinectとunityを組み合わせて落ちてくるボールを取得するモーションキャプチャーを作ろうと思ったが、当たり判定がなく、別の方法を使うことにした。

落ちてくるボールのコードでunityちゃんとボールの座標の差を取得し、触れているように見える座標で処理させるようにした。(boll_35.cs)

そのため、座標の取得にTransformを使っており、ボール一つ一つに触れたら点数が加算されて消えるコードを作成せざるを得なかった。(座標を取得できないとエラーが出るため、他のプログラムからボールをデリートする方法がわからなかった). この問題の解決法があったら更新したい。

また、自分はリズムゲームとして作成したため、x,y軸のみしか使用しなかった。もし、z軸を使いたければ

KinectView/KinectAvotar.csの

Ref.transform.position = new Vector3( pos.X, pos.Y);
のVector3部分をVector3( pos.X, pos.Y, pos.z)と改変すればokなはず.....

-pos.xで動いてる向きと反対に移動させたり、pos.x*2で移動距離を2倍にすることもできる。モーションキャプチャーを動作するときの環境によって移動方向を調整したいときに使えると思う。

