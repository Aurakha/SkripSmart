# Sistem Pakar - Rekomendasi Topik Skripsi (Forward Chaining)

Ringkasan singkat: contoh kecil implementasi metode Forward Chaining untuk menentukan prodi (TI/TMJ/TMD) dan merekomendasikan bidang/topik skripsi.

Run (Python 3, Tkinter included):

```powershell
python app.py
```

Files:
- `app.py` : Tkinter GUI aplikasi (general -> specific -> results)
- `expert_rules.py` : pertanyaan, aturan, dan logika evaluasi forward-chaining

Notes:
- Questions use Likert 1-5.
- Rules for prodi are simple, first-match priority. Thresholds: high >=4, med >=3, low <3.
- The project contains SQL dump `db_SistemPakar (1).sql` with more questions; you can adapt `expert_rules.py` to load from a real DB if desired.

Next steps you might ask me to do:
- Load questions directly from the SQL dump or a live MySQL DB.
- Replace Tkinter with Streamlit for a web UI.
- Save user results to CSV or MySQL.
