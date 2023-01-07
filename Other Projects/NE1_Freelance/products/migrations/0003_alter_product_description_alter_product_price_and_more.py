# Generated by Django 4.1.5 on 2023-01-07 04:30

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('products', '0002_product_summary'),
    ]

    operations = [
        migrations.AlterField(
            model_name='product',
            name='description',
            field=models.TextField(default='Details about this product'),
        ),
        migrations.AlterField(
            model_name='product',
            name='price',
            field=models.TextField(verbose_name='Cost?'),
        ),
        migrations.AlterField(
            model_name='product',
            name='title',
            field=models.TextField(default='What is this product?'),
        ),
    ]
