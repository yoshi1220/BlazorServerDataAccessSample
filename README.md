# BlazorServerDataAccessSample

Blazor ServerでSQL Serverのデータにアクセスし、データを一覧表示するサンプルです。

## Databaseの接続先について

appsettings.jsonのConnectionStringをご自身の環境のSQL Serverに接続先を変更してください。

## Databaseの初期化

パッケージマネージャーコンソールで

```
Update-Database
```

を実行してください。
DBの作成及び、サンプルデータが作成されます。


## 開発環境

- Visual Stduio 2019
- Blazor Server 
- .NET5
- Entity Framework Core 5.0.14
