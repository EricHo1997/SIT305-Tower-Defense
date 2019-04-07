package com.example.fireonfiregame;

import android.content.Intent;
import android.media.MediaPlayer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.VideoView;

public class MainActivity extends AppCompatActivity {

    VideoView videoView;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        videoView = (VideoView) findViewById(R.id.videoIntro);
        videoView.setVideoPath("android.resource://" + getPackageName() + "/" + R.raw.intro);
        videoView.setOnCompletionListener(new MediaPlayer.OnCompletionListener() {
            @Override
            public void onCompletion(MediaPlayer mp) {
                if (isFinishing()) {
                    return;
                }
                startActivity(new Intent(MainActivity.this, SplashScreenActivity.class));
                finish();
            }
        });

        videoView.start();
    }
}
