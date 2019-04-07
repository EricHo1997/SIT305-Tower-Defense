package com.example.fireonfiregame;

import android.animation.ArgbEvaluator;
import android.animation.ObjectAnimator;
import android.graphics.Color;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.animation.Animation;
import android.widget.Button;

public class MenuActivity extends AppCompatActivity {

    private Button button;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);

        button = findViewById(R.id.playButton);

        ManageBlinkEffect();
    }

    private void ManageBlinkEffect() {
        ObjectAnimator animator = ObjectAnimator.ofInt(button, "textColor", Color.TRANSPARENT, Color.DKGRAY, Color.TRANSPARENT);
        animator.setDuration(6000);
        animator.setEvaluator(new ArgbEvaluator());
        animator.setRepeatMode(Animation.REVERSE);
        animator.setRepeatCount(Animation.INFINITE);
        animator.start();
    }
}
