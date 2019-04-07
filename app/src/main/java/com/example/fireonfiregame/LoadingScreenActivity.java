package com.example.fireonfiregame;

import android.graphics.drawable.AnimationDrawable;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.WindowManager;
import android.widget.ImageView;
import android.widget.ProgressBar;
import android.widget.TextView;

public class LoadingScreenActivity extends AppCompatActivity {

    private ProgressBar progressBar;
    private TextView textView;
    private TextView mLoadingText;
    private AnimationDrawable animationDrawable;
    private ImageView imageView;

    private float min = 0f;
    private float max = 100f;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_loadingscreen);

        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        imageView = findViewById(R.id.imageLoading);
        if (imageView == null) throw new AssertionError();
        imageView.setBackgroundResource(R.drawable.animation_loading);

        animationDrawable = (AnimationDrawable)imageView.getBackground();
        animationDrawable.start();

        progressBar = findViewById(R.id.progress_bar);
        textView = findViewById(R.id.loadingPercentTextView);
        mLoadingText = findViewById(R.id.loadingTextView);

        progressBar.setMax(100);
        progressBar.setScaleY(3f);

        progressAnimation();
    }

    public void progressAnimation() {
        progressBarAnimation animation = new progressBarAnimation(this, progressBar, textView, min, max);
        animation.setDuration(8000);
        progressBar.setAnimation(animation);

    }
}
