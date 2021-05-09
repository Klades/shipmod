using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    partial class Form1
    {

        [DllImport("kernel32.dll")]
        static extern UIntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(UIntPtr handle);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern int WriteProcessMemory(
            UIntPtr hProcess, UIntPtr lpBaseAddress,
            byte[] lpBuffer, int nSize, UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32", SetLastError = true)]
        public static extern int ReadProcessMemory(
            UIntPtr hProcess, UIntPtr lpBaseAddress,
            byte[] lpBuffer, int nSize, UIntPtr lpNumberOfBytesRead);

        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_read = new System.Windows.Forms.Button();
            this.comboBox_ship = new System.Windows.Forms.ComboBox();
            this.comboBox_missile = new System.Windows.Forms.ComboBox();
            this.comboBox_bit = new System.Windows.Forms.ComboBox();
            this.comboBox_force = new System.Windows.Forms.ComboBox();
            this.comboBox_cannon = new System.Windows.Forms.ComboBox();
            this.comboBox_dose = new System.Windows.Forms.ComboBox();
            this.comboBox_hangar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(15, 230);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(140, 35);
            this.button_read.TabIndex = 0;
            this.button_read.Text = "機体読み込み";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // comboBox_ship
            // 
            this.comboBox_ship.FormattingEnabled = true;
            this.comboBox_ship.Items.AddRange(new object[] {
            "R-9A　アロー・ヘッド",
            "R-9A2　デルタ",
            "R-9A3　レディー・ラブ",
            "R-9A4　ウエーブマスター",
            "R-9AF　モーニング・グローリー",
            "R-AD　エスコート・タイム",
            "R-9AD2　プリンスダム",
            "R-9AD3　キングスマインド",
            "R-9C　ウォー・ヘッド",
            "R-9K　サンデー・ストライク",
            "R-9S　ストライク・ボマー",
            "R-9φ　ラグナロック",
            "R-9φ2　ラグナロックII",
            "R-9AX　デリカテッセン",
            "R-9AX2　ディナー・ベル",
            "R-9Leo　レオ",
            "R-9Leo2 レオII",
            "R-9Sk　プリンシパリティーズ",
            "R-9Sk2　ドミニオンズ",
            "R-9W　ワイズ・マン",
            "R-9WB　ハッピー・デイズ",
            "R-9WF　スウィート・メモリーズ",
            "R-9WZ　ディザスター・レポート",
            "R-9B　ストライダー",
            "R-9B2　ステイヤー",
            "R-9B3　スレイプニル",
            "R-9D　シューティング・スター",
            "R-9D2　モーニング・スター",
            "R-9DH　グレース・ノート",
            "R-9DH2　ホット・コンダクター",
            "R-9DH3　コンサートマスター",
            "R-9DV　ティアーズ・シャワー",
            "R-9DV2　ノーザン・ライツ",
            "R-9DP　ハクサン",
            "R-9DP2　アサノガワ",
            "R-9DP3　ケンロクエン",
            "R-9E　ミッドナイト・アイ",
            "R-9E2　アウル・ライト",
            "R-9E3　スウィート・ルナ",
            "R-9ER　パワード・サイレンス",
            "R-9ER2　アンチェインド・サイレンス",
            "R-9F　アンドロマリウス",
            "RX-10　アルバトロス",
            "R-11A　フューチャー・ワールド",
            "R-11B　ピース・メーカー",
            "R-11S　トロピカル・エンジェル",
            "R-11S2　ノー・チェイサー",
            "TX-T　エクリプス",
            "OF-1　ダイダロス",
            "OXF-1　ワルキュリア",
            "OF-3　ガルーダ",
            "OXF-4　ソンゴクウ",
            "OF-5　カグヤ",
            "TW-1　ダックビル",
            "TW-2　キウイ・ベリィ",
            "TP-1　スコープ・ダック",
            "TP-2　パウ・アーマー",
            "TP-2H　パウ・アーマー改",
            "TP-3　ミスター・ヘリ",
            "TP-2S　サイバー・ノヴァ",
            "TP-2M　フロッグマン",
            "TL-T　ケイロン",
            "TL-1A　イアソン",
            "TL-1B　アスクレピオス",
            "TL-2A　アキレウス",
            "TL-2A2　ネオプトレモス",
            "TL-2B　ヘラクレス",
            "TL-2B2　ヒュロス",
            "RX-12　クロス・ザ・ルビゴン",
            "R-13T　エキドナ",
            "R-13A　ケルベロス",
            "R-13A2　ハーデス",
            "R-13B　カロン",
            "BX-T　ダンタリオン",
            "B-1A　ジギタリウス",
            "B-1A2　ジギタリウスII",
            "B-1A3　ジギタリウスIII",
            "B-1B　マッド・フォレスト",
            "B-1B2　マッド・フォレストII",
            "B-1B3　マッド・フォレストIII",
            "B-1C　アンフィビアン",
            "B-1C2　アンフィビアンII",
            "B-1C3　アンフィビアンIII",
            "B-1D　バイド・システムα",
            "B-1D2　バイド・システムβ",
            "B-1D3　バイド・システムγ",
            "BX-2　プラトニック・ラブ",
            "B-3A　ミスティー・レディー",
            "B-3A2　ミスティー・レディーII",
            "B-3B　メタリック・ドーン",
            "B-3B2　メタリック・ドーンII",
            "B-3C　セクシー・ダイナマイト",
            "B-3C2　セクシー・ダイナマイトII",
            "BX-4　アーヴァンク",
            "B-5A　クロー・クロー",
            "B-5B　ゴールデン・セレクション",
            "B-5C　プラチナ・ハート",
            "B-5D　ダイヤモンド・ウエディング",
            "R-99　ラスト・ダンサー",
            "R-100　カーテン・コール",
            "R-101　グランド・フィナーレ"});
            this.comboBox_ship.Location = new System.Drawing.Point(131, 41);
            this.comboBox_ship.Name = "comboBox_ship";
            this.comboBox_ship.Size = new System.Drawing.Size(258, 23);
            this.comboBox_ship.TabIndex = 2;
            // 
            // comboBox_missile
            // 
            this.comboBox_missile.FormattingEnabled = true;
            this.comboBox_missile.Items.AddRange(new object[] {
            "追尾ミサイル",
            "誘爆ミサイル",
            "光子ミサイル",
            "爆雷",
            "対地ミサイル",
            "追尾ミサイル改",
            "4WAY追尾ミサイル",
            "6WAY追尾ミサイル",
            "目玉追尾ミサイル",
            "垂直打ち上げ式ミサイル",
            "バルムンク試作型",
            "バルムンク実戦配備型"});
            this.comboBox_missile.Location = new System.Drawing.Point(131, 70);
            this.comboBox_missile.Name = "comboBox_missile";
            this.comboBox_missile.Size = new System.Drawing.Size(258, 23);
            this.comboBox_missile.TabIndex = 3;
            // 
            // comboBox_bit
            // 
            this.comboBox_bit.FormattingEnabled = true;
            this.comboBox_bit.Items.AddRange(new object[] {
            "ラウンド・ビット",
            "シールド・ビット",
            "カメラ・ビット",
            "シャドウ・ビット",
            "眼球・ビット",
            "レッド・ポッド",
            "ブルー・ポッド",
            "サイ・ビット",
            "サイ・ビット改",
            "Mr.ヘリ・ビット",
            "イエロー・ポッド",
            "グリーン・ポッド"});
            this.comboBox_bit.Location = new System.Drawing.Point(131, 99);
            this.comboBox_bit.Name = "comboBox_bit";
            this.comboBox_bit.Size = new System.Drawing.Size(258, 23);
            this.comboBox_bit.TabIndex = 4;
            // 
            // comboBox_force
            // 
            this.comboBox_force.FormattingEnabled = true;
            this.comboBox_force.Items.AddRange(new object[] {
            "スタンダード・フォース",
            "スタンダード・フォースC",
            "スタンダード・フォースK",
            "スタンダード・フォース改",
            "スタンダード・フォースH式",
            "ディフェンシブ・フォース",
            "ディフェンシブ・フォース改",
            "カメラ・フォース",
            "カメラ・フォース2",
            "カメラ・フォース3",
            "球形レドーム・フォース",
            "球形レドーム・フォース改",
            "ファイヤー・フォース",
            "フレイム・フォース",
            "ギャロップ・フォース",
            "ギャロップ・フォース改",
            "チェーン・フォース",
            "アンカー・フォース",
            "アンカー・フォース改",
            "シャドウ・フォース",
            "サイクロン・フォース",
            "Leo・フォース",
            "Leo・フォース改",
            "OF・フォース",
            "OF・フォースII",
            "OF・フォースIII",
            "OF・フォースIV",
            "OF・フォースV",
            "テンタクル・フォース",
            "フレキシブル・フォース",
            "フラワー・フォース",
            "ビースト・フォース",
            "ロッドレス・フォース",
            "ニードル・フォース",
            "ニードル・フォース改",
            "ドリル・フォース",
            "Mr.ヘリ・フォース",
            "キューブ・フォース",
            "バイド・フォース",
            "ゴールド・フォース",
            "プラチナ・フォース",
            "ダイアモンド・フォース",
            "スケイル・フォース",
            "クロー・フォース",
            "セクシー・フォース",
            "ライフ・フォース",
            "ミスト・フォース",
            "メタリック・フォース",
            "愛のフォース",
            "シールド・フォース",
            "ミラーシールド・フォース",
            "ビームサーベル・フォース",
            "アイビー・フォース",
            "キカイマシン・フォース",
            "ドリルホルン・フォース"});
            this.comboBox_force.Location = new System.Drawing.Point(131, 127);
            this.comboBox_force.Name = "comboBox_force";
            this.comboBox_force.Size = new System.Drawing.Size(258, 23);
            this.comboBox_force.TabIndex = 5;
            // 
            // comboBox_cannon
            // 
            this.comboBox_cannon.FormattingEnabled = true;
            this.comboBox_cannon.Items.AddRange(new object[] {
            "スタンダード波動砲",
            "スタンダード波動砲II",
            "スタンダード波動砲III",
            "スタンダード波動砲X",
            "スタンダード波動砲XX",
            "スタンダード波動砲試作型",
            "フォース波動砲",
            "デコイ波動砲",
            "デコイ波動砲II",
            "デコイ波動砲III",
            "メガ波動砲",
            "ギガ波動砲",
            "圧縮波動砲",
            "圧縮波動砲II",
            "持続式圧縮波動砲",
            "持続式圧縮波動砲II",
            "持続式圧縮波動砲III",
            "拡散波動砲",
            "拡散波動砲試作型",
            "衝撃波動砲",
            "衝撃波動砲II",
            "超新星波動砲",
            "幻影波動砲",
            "ライトニング波動砲",
            "ライトニング波動砲試作型",
            "バウンドライトニング波動砲",
            "バイド砲",
            "ハイパー波動砲",
            "災害波動砲",
            "ナノマシン波動砲",
            "分裂波動砲",
            "大砲",
            "バブル波動砲",
            "クリスタル波動砲",
            "圧縮炸裂波動砲",
            "ハッピーシャワー砲",
            "ゴールドラッシュ砲",
            "プリズムリズム砲",
            "クロー波動砲",
            "ダンタリオンの笛",
            "スケイル波動砲",
            "パイルバンカー",
            "パイルバンカー帯電式",
            "パイルバンカー帯電H式",
            "光子バルカン弾",
            "光子バルカン弾II",
            "索敵波動砲",
            "索敵波動砲EX",
            "補足追尾波動砲",
            "ロックオン波動砲",
            "ロックオン波動砲II",
            "ロックオン波動砲III",
            "バイドスピリット砲",
            "バイドスピリット砲II",
            "バイドスピリット砲III",
            "アイビーロッド",
            "スパイクアイビー",
            "プリンセスアイビー",
            "デビルウエーブ砲",
            "デビルウエーブ砲II",
            "デビルウエーブ砲III",
            "アシッドスプレイ",
            "ニトロスプレイ",
            "セクシー波動砲",
            "セクシー波動砲II",
            "フォース波動砲LM",
            "フォース波動砲LM2",
            "バイドシード砲",
            "バイドシード砲II",
            "バイドシード砲III",
            "灼熱波動砲",
            "灼熱波動砲II",
            "バリア波動砲",
            "バリア波動砲II",
            "拡散試作／衝撃波動砲",
            "拡散／圧縮炸裂波動砲",
            "分裂／圧縮炸裂波動砲",
            "スタンダード／衝撃波動砲",
            "スタンダードII／衝撃波動砲II",
            "スタンダード／電撃波動砲",
            "スタンダードII／B電撃波動砲",
            "カーニバル波動砲",
            "カーニバル波動砲II",
            "ラヴ・サイン波動砲",
            "ロングホーン砲"});
            this.comboBox_cannon.Location = new System.Drawing.Point(131, 156);
            this.comboBox_cannon.Name = "comboBox_cannon";
            this.comboBox_cannon.Size = new System.Drawing.Size(258, 23);
            this.comboBox_cannon.TabIndex = 6;
            // 
            // comboBox_dose
            // 
            this.comboBox_dose.FormattingEnabled = true;
            this.comboBox_dose.Items.AddRange(new object[] {
            "ニュークリアカタストロフィー",
            "ネガティブコリドー",
            "ヒステリックドーン",
            "バイディックダンス",
            "エクリプスメモリー",
            "エンボス"});
            this.comboBox_dose.Location = new System.Drawing.Point(131, 185);
            this.comboBox_dose.Name = "comboBox_dose";
            this.comboBox_dose.Size = new System.Drawing.Size(258, 23);
            this.comboBox_dose.TabIndex = 7;
            // 
            // comboBox_hangar
            // 
            this.comboBox_hangar.FormattingEnabled = true;
            this.comboBox_hangar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_hangar.Location = new System.Drawing.Point(131, 12);
            this.comboBox_hangar.Name = "comboBox_hangar";
            this.comboBox_hangar.Size = new System.Drawing.Size(258, 23);
            this.comboBox_hangar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "hangar slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "ship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "missile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "force";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "wave cannon";
            this.label6.UseMnemonic = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "dose";
            this.label7.UseMnemonic = false;
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(249, 230);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(140, 35);
            this.button_write.TabIndex = 16;
            this.button_write.Text = "機体書き込み";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 281);
            this.Controls.Add(this.button_write);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_hangar);
            this.Controls.Add(this.comboBox_dose);
            this.Controls.Add(this.comboBox_cannon);
            this.Controls.Add(this.comboBox_force);
            this.Controls.Add(this.comboBox_bit);
            this.Controls.Add(this.comboBox_missile);
            this.Controls.Add(this.comboBox_ship);
            this.Controls.Add(this.button_read);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "R-TYPE FINAL2 Ship mod 0501";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.ComboBox comboBox_ship;
        private System.Windows.Forms.ComboBox comboBox_missile;
        private System.Windows.Forms.ComboBox comboBox_bit;
        private System.Windows.Forms.ComboBox comboBox_force;
        private System.Windows.Forms.ComboBox comboBox_cannon;
        private System.Windows.Forms.ComboBox comboBox_dose;
        private System.Windows.Forms.ComboBox comboBox_hangar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_write;
    }
}

